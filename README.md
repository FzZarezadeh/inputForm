🧾 User Info Form App

A simple Windows Forms application built in C# that collects user information through one form and displays it on another. This project demonstrates form-to-form communication, basic UI interaction, and image handling in a desktop environment.

---

📦 Features

- Form1 (Input Form):
  - Collects user's name, gender, marital status, and profile picture.
  - Uses radio buttons for gender and marital status selection.
  - Displays a confirmation message before closing.

- Form2 (Display Form):
  - Receives data from Form1 and displays it in text fields.
  - Shows gender and marital status in Persian language.
  - Loads and displays the selected profile image.
  - Exits the application when closed or when the exit button is clicked.

---

🔄 Data Flow

- Form1 gathers user input and stores it in public fields.
- Form2 receives a reference to Form1 via its constructor.
- On load, Form2 accesses the fields from Form1 and populates its controls accordingly.

---

🛠 Technologies Used

- Language: C#
- Framework: .NET Framework (Windows Forms)
- IDE: Visual Studio
- UI Components: RadioButtons, TextBoxes, PictureBox, MessageBox, OpenFileDialog

---

🚀 How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Fill out the form in Form1, choose an image, and submit.
5. Form2 will display the entered information.

---

📁 Project Structure

`
inputForm/
├── Program.cs       // Entry point, launches custom ApplicationContext
├── Form1.cs         // Input form logic
├── Form2.cs         // Display form logic
