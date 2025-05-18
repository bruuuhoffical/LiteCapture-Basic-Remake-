# 🎥 LiteCapture

**LiteCapture** is a sleek and lightweight screen recorder for Windows that captures both video and system audio — no lag, no virtual devices, and zero fluff. Built with C#, FFmpeg, and NAudio for performance and flexibility.

---

## ✨ Features

### 🎮 Capture Modes
- 🖥️ **Fullscreen Recording** – Record your entire screen in one click.
- 🪟 **Specific Window Recording** – Select any open window to record.
- 📋 **Dynamic Window List** – Instantly loads all visible windows for selection.

### 🔊 Audio Recording
- 🎧 **System Audio (Loopback)** – Records all audio played on your PC using native NAudio loopback (no virtual drivers).
- ✅ **Optional Audio Toggle** – Audio capture starts only if enabled.
- 🔗 **Post-Recording Audio-Video Mux** – Cleanly merges recorded audio + video after stop for perfect sync.

### 🎥 Video Controls
- 🎞️ **Custom FPS** – Choose how smooth you want your video.
- 🧮 **Quality Selector (CRF)** – Balance file size and quality using simple presets.
- 📐 **Resolution Options**:
  - ⚡ **High Quality Mode** – Native screen resolution.
  - 📏 **Custom Resolution Dropdown** – Choose output like 720p, 1080p, etc.

### 💻 System Stats
- 📊 **Live CPU & RAM Monitoring** – Real-time performance stats on the UI.
- 🚀 **Threaded Encoding** – Optimized FFmpeg threading for smoother recording.

### 💾 Output Settings
- 📁 **Set Output Folder** – Choose where your files get saved.
- 🧾 **File Format ComboBox** – Select from `.mp4`, `.mkv`, etc.
- 🧃 **Final Output = Clean Muxed Audio + Video** – Always ready to upload/share.

### 🧼 User Experience
- 🫥 **Auto Hide While Recording** – Option to hide app window during session.
- 📢 **Toast Notifications** – Get quick confirmation when recording starts/stops.
- ⚠️ **Smart Error Alerts** – Warnings if audio device fails or FFmpeg crashes.

---

## 🧠 Tech Stack

- 💻 C# (.NET Windows Forms)
- 🎙️ NAudio – Native audio loopback recording
- 🧰 FFmpeg – Encoding powerhouse for screen + audio

---

## 🚀 Coming Soon

- 🎤 Microphone + system audio combo
- 🎚️ Audio input device selector
- ⏱️ Timed/auto-stop recording
- 🧩 Plugin support?

---

## 🧰 Requirements

- Windows 10/11  
- .NET Framework 4.8  
- FFmpeg included in `Resources` folder  
- NAudio (bundled via NuGet or DLLs)

---

## 🏁 How to Use

1. Run the app.
2. Choose output format, resolution, FPS, and capture mode.
3. (Optional) Enable system audio recording.
4. Click **Start Recording**.
5. Click **Stop Recording** when done.
6. Your final video will be saved with audio automatically merged. ✅

---

## 💬 Feedback

Issues or suggestions? send a DM.

---
