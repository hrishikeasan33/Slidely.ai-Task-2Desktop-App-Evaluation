
# Submission App - Windows Desktop Application

Submission App is a Windows Desktop application built with Visual Basic in Visual Studio. This application provides an intuitive interface for managing submissions, allowing users to view and create submission records easily. This project is part of Task 2 for Slidely.ai task submissions.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Keyboard Shortcuts](#keyboard-shortcuts)
- [Forms Overview](#forms-overview)
- [Troubleshooting](#troubleshooting)

## Features

- **View Submissions**: Display detailed information about existing submissions, including name, email, phone number, GitHub link, and stopwatch time.
- **Create Submissions**: Fill in submission details and save them to the backend server, including the ability to track time using an integrated stopwatch.
- **Keyboard Shortcuts**: Efficient navigation and actions through keyboard shortcuts, enhancing the user experience and productivity.
- **Stopwatch Integration**: Track and record the duration of tasks directly within the application.

## Installation

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) (Community, Professional, or Enterprise)
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- A running instance of the backend server (refer to Backend Server Setup for instructions)

### Setup Steps

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/hrishikeasan33/Slidely.ai-Task-2Desktop-App-Evaluation.git)
    cd submission-app
    ```

2. **Open the Solution in Visual Studio**:
    - Launch Visual Studio.
    - Open the solution file `SubmissionApp.sln` located in the `submission-app` directory.

3. **Build the Project**:
    - In Visual Studio, select `Build` -> `Rebuild Solution` from the menu.

## Usage

### Running the Application

1. **Ensure the Backend Server is Running**:
    - Follow the backend setup instructions and start the server.

2. **Run the Desktop Application**:
    - Press `F5` in Visual Studio or select `Debug` -> `Start Debugging`.

## Keyboard Shortcuts

- **View Submissions**: `CTRL + V`
- **Create New Submission**: `CTRL + N`
- **Previous Submission**: `CTRL + P`
- **Next Submission**: `CTRL + N`
- **Submit**: `CTRL + S`
- **Start/Stop Stopwatch**: Click the "START/STOP" button

## Forms Overview

### Main Form (`Form1`)

- **Buttons**:
  - `VIEW SUBMISSIONS (CTRL + V)`: Opens the View Submissions form.
  - `CREATE NEW SUBMISSION (CTRL + N)`: Opens the Create Submission form.
    ![image](https://github.com/hrishikeasan33/Slidely.ai-Task-2Desktop-App-Evaluation/assets/143091137/6a99192a-85da-479f-ba09-596a88b07435)
    ![image](https://github.com/hrishikeasan33/Slidely.ai-Task-2Desktop-App-Evaluation/assets/143091137/d574e8aa-d5f4-4c74-a732-44533143c8c8)



### View Submissions Form (`ViewSubmissionsForm`)

- **Components**:
  - **Labels and Text Boxes** for displaying Name, Email, Phone Number, GitHub Link, and Stopwatch Time.
  - **Navigation Buttons**:
    - `PREVIOUS (CTRL + P)`: Navigate to the previous submission.
    - `NEXT (CTRL + N)`: Navigate to the next submission.
- **Functions**:
  - `ViewSubmissionsForm_Load`: Loads submissions from the backend on form load.
  - `btnPrevious_Click` & `btnNext_Click`: Navigate through submissions.
  - `DisplaySubmission`: Displays the current submission details.
    ![image](https://github.com/hrishikeasan33/Slidely.ai-Task-2Desktop-App-Evaluation/assets/143091137/e5fd2abf-82f7-4d25-ba82-ebffc58d4c35)


### Create Submission Form (`CreateSubmissionForm`)

- **Components**:
  - **Text Boxes and Labels** for Name, Email, Phone Number, GitHub Link.
  - **Buttons**:
    - `SUBMIT (CTRL + S)`: Submits the new submission to the backend server.
    - `START/STOP` (Stopwatch): Starts or stops the stopwatch.
- **Functions**:
  - `btnStopwatch_Click`: Starts or stops the stopwatch.
  - `btnSubmit_Click`: Collects the data and sends it to the backend server for storage.
![image](https://github.com/hrishikeasan33/Slidely.ai-Task-2Desktop-App-Evaluation/assets/143091137/d5ce9e13-5e7f-4d00-962c-7de48d7643be)
![image](https://github.com/hrishikeasan33/Slidely.ai-Task-2Desktop-App-Evaluation/assets/143091137/06fdc42c-bb99-48c7-8644-562fde2b6222)


## Troubleshooting

- **Designer Load Errors**: Ensure the form class is the first class in the file. Move supporting classes (like `Submission`) to separate files.
- **Backend Connection Issues**: Verify the backend server is running and accessible at `http://localhost:3000`.
- **Build Errors**: Ensure all necessary NuGet packages and project dependencies are installed.
