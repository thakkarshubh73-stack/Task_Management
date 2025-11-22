# 📝 Modern Task Manager

A robust, responsive, and aesthetically pleasing Task Management application built with **Angular (Signals)** and styled with a modern **Glassmorphism** UI. This application allows users to create, track, prioritize, and manage daily tasks efficiently.


## ✨ Key Features

* **Full CRUD Operations:** Create, Read, Update, and Delete tasks seamlessly.
* **Angular Signals:** Utilizes the latest Angular state management for high performance and reactivity.
* **Modern UI:** Custom CSS featuring Glassmorphism (frosted glass effect), gradients, and smooth animations.
* **Smart Filtering:** Real-time search and status filtering (Pending, In Progress, Completed).
* **Deadline Tracking:** Visual indicators for "Urgent" (due soon) and "Overdue" tasks.
* **Responsive Design:** Fully optimized for desktop, tablet, and mobile screens.

## 🛠️ Tech Stack

* **Framework:** Angular 20 (Standalone Components)
* **Language:** TypeScript
* **State Management:** Angular Signals (`signal`, `computed`)
* **Styling:** Pure CSS (CSS Variables, Flexbox, Grid)
* **Backend:** Connected to a REST API (.NET Core)

## 🚀 Getting Started

Follow these instructions to set up the project locally.

### Prerequisites

* **Node.js** (v20 or higher)
* **Angular CLI** (`npm install -g @angular/cli`)

### Installation

1.  **Install dependencies**
    ```bash
    npm install
    ```

2.  **Configure the API**
    Open `src/app/services/task.service.ts` and ensure the `apiUrl` matches your backend server:
    ```typescript
    private api = 'https://localhost:7286/api/TaskManagement';
    ```

3.  **Run the application**
    ```bash
    ng serve
    ```
    Navigate to `http://localhost:4200/` in your browser.

## ⚙️ Configuration Guide

### Connecting the API
If your backend returns plain text instead of JSON for deletions, update your delete method in `task.service.ts`:

```typescript
delete(id: number): Observable<any> {
  return this.http.delete(`${this.api}/${id}`, { responseType: 'text' });
}



###Project Structure

src/
├── app/
│   ├── models/
│   │   └── task.interface.ts    
│   ├── services/
│   │   └── task.service.ts      # API Communication
│   ├── tasklist/
│   │   ├── tasklist.ts    # Logic (Signals)
│   │   ├── tasklist.html  # Template
│   │   └── tasklist.css   # Styles
│   └── app.config.ts
└── main.ts


