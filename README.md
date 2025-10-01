# DiaryApp



\# DiaryApp



A simple console-based diary application written in C#.



\## Features

\- Add new diary notes

\- List all diary notes

\- Search notes by date (yyyy-MM-dd)

\- Save notes to a file (diary.txt)

\- Load notes from a file

\- Error handling with try/catch



how to use:



Open the project with visual studio or similar software. Follow the menu instructions bellow



1\) Add new diary note

2\) List all diary notes

3\) Search diary note by date

4\) Save notes to file

5\) Load notes from file

6\) Exit





Reflection

I chose to store notes in a List<DiaryEntry> because it is simple and effective for this project.  

The notes are saved in a text file using the format date|text, which makes saving and loading easy.  

For input validation I used string.IsNullOrWhiteSpace` and DateTime.TryParse.  

File operations are wrapped in `try/catch` to handle errors like missing files.

