# Advanced C#: Language Features
This is the repository for the LinkedIn Learning course Advanced C#: Language Features. The full course is available from [LinkedIn Learning][lil-course-url].

![Advanced C#: Language Features][lil-thumbnail-url] 

In this advanced C# course, instructor Joe Marini dives deep into language features. Joe goes over language constructs such as indexes and ranges, literal number improvements, the null-coalescing operator, and two uses for deconstruction syntax. He gives you an overview of pattern matching, then shows you basic patterns, enhanced switch statements, position patterns, and relational patterns. Joe covers object-oriented programming features, including how to work with indexers, override the ToString method of a class, and conduct equality testing. Plus, he walks you through using records to create types that have common default behaviors and immutability.

_See the readme file in the main branch for updated instructions and information._
## Instructions
This repository has the starting and finished example code for the Advanced C#: Language Features course. Use the starting point code to follow along with the course and build towards the finished examples. Use the finished examples to learn more about how each of the various features of C# work.

## Installing
1. To use these exercise files, you must have the following installed:
	- A text editor or IDE, such as Visual Studio, Visual Studio Code, Atom, etc
	- The .NET SDK, version 6
2. Clone this repository into your local machine using the terminal (Mac), CMD (Windows), or a GUI tool like SourceTree.

## Branches
The branches are structured to correspond to the videos in the course. The naming convention is `CHAPTER#_MOVIE#`. As an example, the branch named `02_03` corresponds to the second chapter and the third video in that chapter. 
Some branches will have a beginning and an end state. These are marked with the letters `b` for "beginning" and `e` for "end". The `b` branch contains the code as it is at the beginning of the movie. The `e` branch contains the code as it is at the end of the movie. The `main` branch holds the final state of the code when in the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"


### Instructor

Joe Marini 
                            
Senior Director of Product and Engineering

                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/joe-marini).

[lil-course-url]: https://www.linkedin.com/learning/advanced-c-sharp-language-features
[lil-thumbnail-url]: https://cdn.lynda.com/course/2491189/2491189-1661448125983-16x9.jpg
