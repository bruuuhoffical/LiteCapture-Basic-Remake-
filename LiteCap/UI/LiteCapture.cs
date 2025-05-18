using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;
using NAudio.Wave.Compression;
using System.IO;
using System.Threading;
using NAudio.Wave;


namespace LiteCap.UI
{
    public partial class LiteCapture : Form
    {
        private WasapiLoopbackCapture audioCapture;
        private WaveFileWriter audioWriter;
        private string audioTempFile;
        private string rawVideoFile;
        private string finalOutputFile;


        public LiteCapture()
        {
            InitializeComponent();
        }
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderThickness = 2;
            Color borderColor = Color.Silver;

            using (Pen borderPen = new Pen(borderColor, borderThickness))
            {
                e.Graphics.DrawRectangle(
                    borderPen,
                    borderThickness / 2,
                    borderThickness / 2,
                    this.ClientSize.Width - borderThickness,
                    this.ClientSize.Height - borderThickness
                );
            }
        }
        private void PopulateWindowList()
        {
            window.Items.Clear();

            EnumWindows((hWnd, lParam) =>
            {
                if (IsWindowVisible(hWnd))
                {
                    int length = GetWindowTextLength(hWnd);
                    if (length > 0)
                    {
                        var builder = new System.Text.StringBuilder(length + 1);
                        GetWindowText(hWnd, builder, builder.Capacity);
                        string windowTitle = builder.ToString();

                        if (!string.IsNullOrWhiteSpace(windowTitle) && windowTitle.Length > 1)
                        {
                            window.Items.Add(windowTitle);
                        }
                    }
                }
                return true;
            }, IntPtr.Zero);

            if (window.Items.Count > 0)
            {
                window.SelectedIndex = 0; 
            }
        }

        private void LiteCapture_Load(object sender, EventArgs e)
        {
            startrec.BringToFront();
            cmbResolution.Hide();
            string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            string capturePath = Path.Combine(basePath, "Lite Captures");

            if (!Directory.Exists(capturePath))
            {
                Directory.CreateDirectory(capturePath);
            }

            txtOutputPath.Text = capturePath;
            window.Enabled = false;
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            systemStatsTimer.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fullscreen_Click(object sender, EventArgs e)
        {
            
        }

        private void specificwindow_Click(object sender, EventArgs e)
        {
            
        }

        private void fullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (fullscreen.Checked)
            {
                window.Enabled = false;
                specificwindow.Checked = false;
            }
            else
            {
                window.Enabled = true;
                specificwindow.Checked = true;
            }
        }

        private void specificwindow_CheckedChanged(object sender, EventArgs e)
        {
            if (specificwindow.Checked)
            {
                PopulateWindowList();
                window.Enabled = true;
                fullscreen.Checked = false;
                string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                string capturePath = Path.Combine(basePath, "Lite Captures");

                if (!Directory.Exists(capturePath))
                {
                    Directory.CreateDirectory(capturePath);
                }

                txtOutputPath.Text = capturePath;
            }
            else
            {
                window.Items.Clear();
                window.Enabled = false;
                fullscreen.Checked = true;
            }
        }

        private void window_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void specificwindow_Click_1(object sender, EventArgs e)
        {

        }
        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private int GetCrfFromQuality()
        {
            string selected = recquality.SelectedItem.ToString().Replace("%", "");
            int quality = int.TryParse(selected, out int q) ? q : 100;

            int crf = 38 - (int)Math.Round((quality / 100.0) * 20);

            return Clamp(crf, 18, 38);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Output Folder";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = dialog.SelectedPath;
                }
            }
        }
        private ulong GetTotalMemoryInMB()
        {
            var searcher = new ManagementObjectSearcher("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem");
            foreach (var obj in searcher.Get())
            {
                return (ulong)obj["TotalVisibleMemorySize"] / 1024;
            }
            return 0;
        }

        private void systemStatsTimer_Tick(object sender, EventArgs e)
        {
            float cpu = cpuCounter.NextValue(); 
            float availableRam = ramCounter.NextValue(); 

            ulong totalRam = GetTotalMemoryInMB();
            ulong usedRam = totalRam - (ulong)availableRam;
            double totalRamGb = totalRam / 1024.0;

            lblCpu.Text = $"{cpu:F1}%";
            lblRam.Text = $"{usedRam} MB / {totalRamGb:F1} GB";
        }
        private string GetFirstAudioDevice()
        {
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ffmpeg.exe");
                    p.StartInfo.Arguments = "-list_devices true -f dshow -i dummy";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;

                    p.Start();
                    string result = p.StandardError.ReadToEnd();
                    p.WaitForExit();

                    var lines = result.Split('\n');
                    foreach (var line in lines)
                    {
                        if (line.Contains("]  \"") && line.Contains("audio devices"))
                            continue;

                        if (line.Contains("]  \"") && line.Contains("audio"))
                        {
                            int start = line.IndexOf('"') + 1;
                            int end = line.LastIndexOf('"');
                            if (start > 0 && end > start)
                            {
                                return line.Substring(start, end - start);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detecting audio device: " + ex.Message);
            }

            return "";
        }

        private string GetDefaultAudioDevice()
        {
            var output = "";
            try
            {
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = "ffmpeg.exe";
                    p.StartInfo.Arguments = "-list_devices true -f dshow -i dummy";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardError = true;
                    p.StartInfo.CreateNoWindow = true;

                    p.Start();
                    string result = p.StandardError.ReadToEnd();
                    p.WaitForExit();

                    var lines = result.Split('\n');
                    var audioLines = lines
                        .Where(l => l.Contains("DirectShow audio devices"))
                        .Concat(lines.Where(l => l.Contains("\"")))
                        .ToList();

                    foreach (string line in audioLines)
                    {
                        if (line.Contains("Alternative name") || line.Contains("dummy")) continue;
                        int quoteStart = line.IndexOf('"');
                        int quoteEnd = line.LastIndexOf('"');
                        if (quoteStart != -1 && quoteEnd != -1 && quoteEnd > quoteStart)
                        {
                            output = line.Substring(quoteStart + 1, quoteEnd - quoteStart - 1);
                            break; 
                        }   
                    }
                }
            }
            catch { output = ""; }

            return string.IsNullOrEmpty(output) ? "audio=default" : output;
        }


        private Process ffmpegProcess;
        private void StartRecording()
        {
            string outputFolder = txtOutputPath.Text;
            string format = outputformat.SelectedItem?.ToString().ToLower() ?? "mp4";
            int crf = GetCrfFromQuality();
            string timestamp = DateTime.Now.ToString("yyyy_MM_dd_HH_mm");

            rawVideoFile = Path.Combine(outputFolder, $"Recording_{timestamp}_video.{format}");
            audioTempFile = Path.Combine(Path.GetTempPath(), $"Recording_{timestamp}_audio.wav");
            finalOutputFile = Path.Combine(outputFolder, $"Recording_{timestamp}.{format}");

            bool recordAudio = chkAudio.Checked;
            bool hideWindow = chkHideWhileRecording.Checked;
            int fps = (int)nmrFps.Value;

            string videoInput;
            if (specificwindow.Checked && window.SelectedItem != null)
            {
                string windowTitle = window.SelectedItem.ToString();
                videoInput = $"-f gdigrab -framerate {fps} -i title=\"{windowTitle}\"";
            }
            else
            {
                var bounds = Screen.PrimaryScreen.Bounds;
                videoInput = $"-f gdigrab -framerate {fps} -offset_x {bounds.X} -offset_y {bounds.Y} -video_size {bounds.Width}x{bounds.Height} -i desktop";
            }

            string scalePart = "-vf scale=1280:720";
            if (chkHighQuality.Checked)
            {
                scalePart = "-vf scale=trunc(iw/2)*2:trunc(ih/2)*2";
            }
            else if (cmbResolution.SelectedItem != null)
            {
                string[] parts = cmbResolution.SelectedItem.ToString().Split('x');
                if (parts.Length == 2)
                {
                    string width = parts[0].Trim();
                    string height = parts[1].Trim();
                    scalePart = $"-vf scale={width}:{height}";
                }
            }

            string crfPart = $"-c:v libx264 -preset veryfast -pix_fmt yuv420p -crf {crf}";
            string threadPart = "-threads 1";
            string output = $"\"{rawVideoFile}\"";

            string arguments = $"{videoInput} {crfPart} {scalePart} {threadPart} -y {output}";
            string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ffmpeg.exe");

            ffmpegProcess = new Process();
            ffmpegProcess.StartInfo.FileName = ffmpegPath;
            ffmpegProcess.StartInfo.Arguments = arguments;
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.CreateNoWindow = true;
            ffmpegProcess.StartInfo.RedirectStandardError = true;
            ffmpegProcess.StartInfo.RedirectStandardInput = true;
            ffmpegProcess.EnableRaisingEvents = true;

            ffmpegProcess.Exited += (s, e) =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    toastDialog.Show("Recording process exited.");
                    stoprec.Enabled = false;
                    startrec.BringToFront();
                }));
            };

            ffmpegProcess.ErrorDataReceived += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(e.Data))
                    File.AppendAllText("ffmpeg_log.txt", e.Data + Environment.NewLine);
            };

            try
            {
                if (recordAudio)
                {
                    audioCapture = new WasapiLoopbackCapture();
                    audioWriter = new WaveFileWriter(audioTempFile, audioCapture.WaveFormat);

                    audioCapture.DataAvailable += (s, a) =>
                    {
                        if (audioWriter != null)
                            audioWriter.Write(a.Buffer, 0, a.BytesRecorded);
                    };

                    audioCapture.RecordingStopped += (s, a) =>
                    {
                        audioWriter?.Dispose();
                        audioWriter = null;
                        audioCapture?.Dispose();
                        audioCapture = null;
                    };

                    audioCapture.StartRecording();
                }

                ffmpegProcess.Start();
                ffmpegProcess.BeginErrorReadLine();

                toastDialog.Show("Recording started successfully!");
                if (hideWindow) this.Hide();

                stoprec.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to start recording: " + ex.Message);
            }
        }





        private void startrec_Click(object sender, EventArgs e)
        {
            StartRecording();
            stoprec.BringToFront();
        }
        private void StopRecording()
        {
            try
            {
                if (ffmpegProcess != null && !ffmpegProcess.HasExited)
                {
                    ffmpegProcess.StandardInput.WriteLine("q");
                    ffmpegProcess.WaitForExit(3000);

                    if (!ffmpegProcess.HasExited)
                        ffmpegProcess.Kill();

                    ffmpegProcess.Dispose();
                    ffmpegProcess = null;
                }

                if (audioCapture != null)
                {
                    audioCapture.StopRecording();
                }

                if (chkAudio.Checked && File.Exists(audioTempFile) && File.Exists(rawVideoFile))
                {
                    string muxCmd = $"-i \"{rawVideoFile}\" -i \"{audioTempFile}\" -c:v copy -c:a aac -strict experimental \"{finalOutputFile}\"";
                    string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "ffmpeg.exe");

                    Process muxProcess = new Process();
                    muxProcess.StartInfo.FileName = ffmpegPath;
                    muxProcess.StartInfo.Arguments = muxCmd;
                    muxProcess.StartInfo.UseShellExecute = false;
                    muxProcess.StartInfo.CreateNoWindow = true;
                    muxProcess.Start();
                    muxProcess.WaitForExit();

                    File.Delete(rawVideoFile);
                    File.Delete(audioTempFile);
                }
                else if (File.Exists(rawVideoFile))
                {
                    File.Move(rawVideoFile, finalOutputFile);
                }

                if (chkHideWhileRecording.Checked)
                    this.Show();

                toastDialog.Show("Recording stopped and saved.");
                startrec.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping recording: " + ex.Message);
            }
        }




        private void cmbResolution_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHighQuality.Checked)
            {
                cmbResolution.Enabled = false;
                cmbResolution.Hide();
                label8.Text = "Default Resolution";
            }
            else
            {
                cmbResolution.Enabled = true;
                cmbResolution.Show();
                label8.Text = "Custom Resolution";
            }
        }

        private void chkHighQuality_Click(object sender, EventArgs e)
        {

        }

        private void cmbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("This Part Isnt Developed Yet :)");
        }

        private void stoprec_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            ffmpegProcess.Kill();
            Thread.Sleep(500);
            ffmpegProcess.Dispose();
            ffmpegProcess = null;
            Application.Exit();
            Environment.Exit(0);
        }

        private void chkAudio_Click(object sender, EventArgs e)
        {

        }

        private void chkAudio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
