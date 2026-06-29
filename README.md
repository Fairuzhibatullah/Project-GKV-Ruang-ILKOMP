# Virtual Tour Eksplorasi Ruangan Ilmu Komputer SSMI IPB University

# 📌 Project Setup

Dokumen ini menjelaskan langkah-langkah untuk menjalankan proyek Unity dengan benar.

---

# 📋 Persyaratan

Sebelum membuka proyek, pastikan perangkat lunak berikut telah terpasang:

* Unity **2022.3 LTS** + **VR Template**
* Visual Studio atau Visual Studio Code *(opsional untuk pengembangan script C#)*
* Git
* Git LFS

---

# 📥 Clone Repository

Clone repository ke komputer Anda menggunakan perintah berikut:

```bash
git clone <repository-url>
```

Masuk ke folder proyek:

```bash
cd <repository-folder>
```

---

# ⚠️ Penting: Unduh Asset Git LFS

Proyek ini menggunakan **Git Large File Storage (Git LFS)** untuk menyimpan aset berukuran besar seperti:

* Panorama 360°
* Texture
* Audio
* Gambar UI
* Media lainnya

Setelah proses clone selesai, **WAJIB** jalankan perintah berikut:

```bash
git lfs install
git lfs pull
```

> **Jangan melewati langkah ini.**

Jika langkah ini tidak dilakukan, kemungkinan akan muncul masalah seperti:

* Asset panorama tidak muncul
* Texture menjadi rusak atau berwarna ungu (missing texture)
* Audio tidak tersedia
* Unity gagal mengimpor asset
* Error seperti:

```text
Could not create asset
File could not be read
```

Pastikan seluruh file Git LFS telah berhasil terunduh sebelum membuka proyek di Unity.

---

# 🎮 Persyaratan Unity

Proyek ini dikembangkan menggunakan:

* Unity **2022.3 LTS**
* XR Interaction Toolkit
* Unity VR Template

Apabila Unity menampilkan notifikasi mengenai package yang belum terpasang, buka:

```
Window
    └── Package Manager
```

Kemudian pastikan package berikut telah terinstal:

* XR Interaction Toolkit
* XR Core Utilities
* Input System

---

# 🚀 Membuka Proyek

Setelah seluruh asset selesai diunduh dan package telah terpasang:

1. Buka **Unity Hub**
2. Pilih **Add Project**
3. Arahkan ke folder proyek yang telah di-clone
4. Buka menggunakan **Unity 2022.3 LTS**

Unity akan melakukan proses import asset pada saat pertama kali dibuka. Proses ini mungkin memerlukan beberapa menit tergantung spesifikasi komputer.

---

# ✅ Verifikasi

Apabila seluruh langkah telah dilakukan dengan benar, proyek akan berhasil dimuat dengan komponen berikut:

* Panorama 360°
* Lingkungan Virtual
* User Interface (UI)
* Audio
* Sistem Interaksi VR
* Hotspot
* Navigation System
* Interactive Map
* Progress System

---

# ⚠️ Catatan

* Gunakan **Unity 2022.3 LTS** agar kompatibilitas proyek tetap terjaga.
* Jangan menghapus folder **Library** ketika Unity masih berjalan.
* Pastikan seluruh asset Git LFS telah berhasil diunduh sebelum melakukan commit atau menjalankan proyek.
* Jika muncul error terkait package XR, buka **Package Manager** dan instal package yang diperlukan sebelum menjalankan scene.

---
## 📖 Overview

**Virtual Tour Eksplorasi Ruangan Ilmu Komputer SSMI IPB University** merupakan aplikasi **Virtual Reality (VR)** berbasis **Unity** yang dirancang untuk memberikan pengalaman eksplorasi lingkungan Program Studi Ilmu Komputer SSMI IPB University secara interaktif menggunakan panorama 360°.

Aplikasi ini memungkinkan pengguna untuk menjelajahi berbagai fasilitas akademik seperti laboratorium, ruang kelas, dan area umum melalui pengalaman virtual yang imersif. Pengguna juga dapat berinteraksi dengan hotspot informasi, menggunakan peta interaktif, serta mengikuti alur eksplorasi yang terstruktur.

Proyek ini dikembangkan sebagai media pengenalan lingkungan kampus bagi calon mahasiswa, mahasiswa baru, maupun pengunjung.

---

# 🎥 Demo

## Video Demonstrasi

> https://drive.google.com/file/d/1h2xfDOqrB3xRPtKGStIj-6XzPkBKqi5r/view?usp=sharing

```
```

---

# 🚀 Project Information

| Item          | Description                      |
| ------------- | -------------------------------- |
| Project Type  | Virtual Reality Interactive Tour |
| Engine        | Unity                            |
| Language      | C#                               |
| Unity Version | Unity 2022.3 LTS                 |
| Platform      | Virtual Reality                  |

---

# ✨ Features

* 🌐 Eksplorasi panorama 360°
* 📍 Navigasi antar lokasi
* ℹ️ Hotspot informasi interaktif
* 🗺️ Interactive map
* 🔓 Sistem unlock lokasi secara bertahap
* 📈 Progress eksplorasi
* 🔊 Ambient background audio
* 🏠 Main menu & navigation system
* ✅ Completion popup setelah seluruh lokasi selesai dijelajahi

---

# 🛠️ Technologies

* Unity Engine
* C#
* Unity XR Interaction Toolkit
* Panorama 360°
* Git & GitHub
* Figma

---

# 📍 Exploration Locations

## FMIPA Kering

1. Depan FMIPA
2. Golden Corner
3. Komlong
4. Lab Komputer 1
5. Lab Komputer 2
6. Lab Komputer 3

## FAPET

7. Depan FAPET
8. Bawah Lift FAPET
9. Depan Lift Lantai 5
10. Kelas Wing 6
11. Kelas Wing 7
12. Kelas Wing 8

## LSI

13. Depan Gedung LSI
14. Lab Hall B
15. Lab GPK

---

# 🗺️ Exploration Flow

```text
Main Menu
    │
    ▼
Depan FMIPA
    │
    ▼
Golden Corner
    │
    ▼
Komlong
    │
    ▼
Lab Komputer 1
    │
    ▼
Lab Komputer 2
    │
    ▼
Lab Komputer 3
    │
    ▼
Depan FAPET
    │
    ▼
Bawah Lift FAPET
    │
    ▼
Depan Lift Lantai 5
    │
    ▼
Wing 6
    │
    ▼
Wing 7
    │
    ▼
Wing 8
    │
    ▼
Depan Gedung LSI
    │
    ▼
Lab Hall B
    │
    ▼
Lab GPK
    │
    ▼
Completion Popup
```

---

# 🎮 Gameplay Mechanics

## Exploration

Pengguna menjelajahi setiap lokasi menggunakan panorama 360° sehingga memperoleh pengalaman virtual yang menyerupai kondisi nyata.

## Hotspot Interaction

Setiap lokasi memiliki hotspot interaktif yang menampilkan:

* Informasi lokasi
* Deskripsi fasilitas
* Informasi akademik

## Navigation

Navigasi tersedia melalui:

* Next Button
* Back Button
* Interactive Map
* Home Button

## Progression System

Lokasi berikutnya akan terbuka setelah pengguna menyelesaikan eksplorasi lokasi sebelumnya.

## Completion System

Setelah seluruh lokasi berhasil dikunjungi, pengguna akan memperoleh popup penyelesaian dan dapat:

* Kembali ke Main Menu
* Melanjutkan eksplorasi secara bebas

---

# 📂 Main Scripts

### SceneUIManager

Mengelola:

* Scene Navigation
* Popup
* Main Menu
* Completion Popup

---

### ProgressManager

Mengelola:

* Progress eksplorasi
* Penyimpanan menggunakan PlayerPrefs
* Progress popup

---

### InfoUnlockManager

Mengelola:

* Unlock tombol **Next** setelah popup informasi selesai dibaca

---

### MapManager

Mengelola:

* Lock & Unlock lokasi pada Interactive Map

---

### AudioManager

Mengelola:

* Ambient Audio
* Mute / Unmute

---

# 🖼️ Panorama Requirements

### Format

* JPG
* PNG

### Aspect Ratio

```
2 : 1
```

### Recommended Resolution

* 11904 × 5952
* 9008 × 2144

### Rendering Method

* Inverted Sphere Mapping

---

# 📅 Development Roadmap

## Week 12

* Project planning
* Menentukan lokasi
* Menyusun alur eksplorasi

## Week 13

* Setup Unity Project
* Pengambilan panorama
* Pembuatan scene awal

## Week 14

* Implementasi panorama
* Sistem navigasi
* Hotspot interaktif

## Week 15

* Implementasi UI
* Interactive Map
* Audio System
* Progression System

## Week 16

* Testing
* Bug Fixing
* Persiapan Presentasi

---

# 🎯 Project Scope (MVP)

## Included

* Panorama-based exploration
* Educational information
* Guided virtual tour
* Lightweight VR interaction

## Not Included

* Multiplayer
* Combat System
* Artificial Intelligence
* Open World Movement
* Complex Physics Simulation

---

# 👥 Development Team

**FairuzHebat Team**

* Faisal Mumtaz Hidayat
* Fairuz Hibatullah
* Muh Arifaushan
* Muhammad Ammar Rizky

---

# 🎓 Credits

Proyek ini dikembangkan sebagai **Final Project** pada mata kuliah Grafika Komputer dan Visualisasi (KOM1304).

**Program Studi Ilmu Komputer**
**Sekolah Sains Data, Matematika, dan Informatika**
**IPB University**
