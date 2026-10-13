## 1. What happens if the text file already exists when you write to it?
When using File.CreateText(), the existing file is overwritten. Its previous contents are removed and replaced by the new text.

## 2. What does the @ symbol before the quoted string mean?
The @ creates a verbatim string. It tells C# to treat characters such as backslashes literally.

Without @, backslashes can be interpreted as escape characters.

## 3. Do you need to wrap the file access with using StreamReader and using StreamWriter? What would happen if you don't do it?
It is recommended because "using" automatically closes and disposes the file stream when it is finished.
Without disposing the reader or writer properly, the file may remain open or locked, and buffered data may not be completely written to the file.

## 4. How is using StreamReader different from File.ReadAllText()?
StreamReader can read the file gradually, such as one line at a time, so it is better for large files.
File.ReadAllText() reads the entire file into memory at once. It is simpler for small files, but less memory-efficient for very large files.