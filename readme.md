# Large File Splitter

This is an application that will split a large text file into smaller files. This works great for splitting:

- comma separated values (csv) files
- log files

Sometimes you're dealing with a large text file that cannot load well in a text editor. This application will split the file into more files; as many as you like.

This application splits on **rows** or lines in the file. The original file isn't modified or deleted in any way.
 
# How to debug this program?

+ Arg 1 is the file you want to split.
+ Arg 2 is the number of files to create when splitting the content of the target.

![How to debug](https://github.com/user-attachments/assets/85315a19-672a-4b99-9d0e-9c9712551acb)

## Developer Guidelines

https://docs.google.com/document/d/152ENUyNAZvEHcfn0QeNbh-9nxgFzxS6RN-O4t2T13lA

## Customers CSV Sample

- [customers-100.csv](https://drive.google.com/uc?id=1zO8ekHWx9U7mrbx_0Hoxxu6od7uxJqWw&export=download) - [Zip version](https://drive.google.com/uc?id=1yyL20BNKv3PxJRJVjJ_2Q-HidvIUis45&export=download) - Customers CSV with 100 records
- [customers-1000.csv](https://drive.google.com/uc?id=1OT84-j5J5z2tHoUvikJtoJFInWmlyYzY&export=download) - [Zip version](https://drive.google.com/uc?id=17CIha7N1jOJWFd3G-CdlA5JplCnGj67x&export=download) - Customers CSV with 1000 records
- [customers-10000.csv](https://drive.google.com/uc?id=1x2IdSNcHGLmot9i1h90gwMJr5lULC2QV&export=download) - [Zip version](https://drive.google.com/uc?id=1peI5sBNUVN_Q7qhgZwwCEejpMR1NjOwd&export=download) - Customers CSV with 10000 records
- [customers-100000.csv](https://drive.google.com/uc?id=1N1xoxgcw2K3d-49tlchXAWw4wuxLj7EV&export=download) - [Zip version](https://drive.google.com/uc?id=1ZCVi_08A8W0f6q-2sVHDPyGzC0S7o4r4&export=download) - Customers CSV with 100000 records
- [customers-500000.csv](https://drive.google.com/uc?id=1f_lRSEobcCqoigHnc9mzli8fbK18loQm&export=download) - Customers CSV with 500000 records
- [customers-1000000.csv](https://drive.google.com/uc?id=16WH96smhIT0KK0ZVJRpjymLa_XDhKOoD&export=download) - Customers CSV with 1000000 records
- [customers-2000000.csv](https://drive.google.com/uc?id=1IXQDp8Um3d-o7ysZLxkDyuvFj9gtlxqz&export=download) - Customers CSV with 2000000 records

### [Download this application (11 KB)](https://github.com/philoushka/LargeFileSplitter/releases/download/v1.1/LargeFileSplitter.exe) ###
 
Running The Splitter App

**The only requirement**: You'll need .NET Framework 4.5 installed on the machine.

The application will ask you for 2 pieces of information:

- the file to split (the source file)
- how many files you want (the target files)

**Sending Arguments**

You can pass these 2 values as arguments to the app from the command line.

![](readme/cli.png)

**Running Interactively**

You can run the console app directly in Windows, and it'll prompt you for the 2 arguments it'll need.

![](readme/console.png)

# Notes

- if your input file doesn't exist, you'll be notified with a message like `Couldn't find that file. We're done here.`
- if you enter a non-integer number(like `foo` or `4.5`, then the application will default to **2**.
- any existing split files will be overwritten.
- the first line from the file will be pasted into the top of each new file. We're assuming here that this line contains column names for a CSV.
- the new files will have the same case as the args you enter. i.e. `foo.csv` will produce `0-foo.csv`, even though the large file on disk is `Foo.CSV`. This is due to the implementation of [`FileInfo`](http://msdn.microsoft.com/en-us/library/system.io.fileinfo.aspx) in the .NET Framework.
- if the source file is empty, then the split files won't be created.
- as usual, you'll need double quotes surrounding your source file when sending a file path with spaces.

# Benchmarks

- 300 MB csv file -> 4.3 sec.
- 600 MB csv file -> 8.6 sec.
- 1 GB csv file -> 61 sec.

# References

https://github.com/philoushka/LargeFileSplitter

https://github.com/lemire/CsharpCSVBench
