The Wedding Shop – Technical Test

Candidate Name : Girish Das
Code for :  Mars Rover 

Q1.  What designed pattern is used?
A1. I have applied SOLID design pattern.

Q2.  What is the code approach?
A2.  I have applied TDD (Test driven development) code approaches. Test First and then Evolve the Code and Refactor until successful .

Q3.  What Unit Test scenarios  are applied?
A3. There are two test scenarios for each test input.
       TestScanrio 1 : est_12N_LMLMLMLMM() and TestScanrio 2: Test_33E_MRRMMRMRRM()

Q4. When application is run , What Test input need ( Scenario 1) to be entered ( For each line below press enter)
A4. 

5 5
1 2 N
LMLMLMLMM

Expected Output:

1 3 N


Q5. When run the application, What Test input need (Scenario 2) to be entered ( For each line below press enter)
A5.
 
5 5
3 3 E
MMRMMRMRRM

Expected Output:

5 1 E


Problem 

Introduction
Below is a fun coding task that we would like you to complete. It should be considered an opportunity to demonstrate your creativity and ability to think outside the box. The problem demonstrates the minimum required for the output.

You may also include a brief explanation of your design and assumptions along with your code.

Problem - Mars Rover
A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on-board cameras can get a complete view of the surrounding terrain to send back to Earth.

A rover's position and location are represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point and maintain the same heading.

Assume that the square directly North from (x, y) is (x, y+1).

Write a simple application that takes a user’s starting point, and then directional instructions and displays the resulting position to the user.

INPUT
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
 
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau.
 
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation.
 
Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

OUTPUT
The output for each rover should be its final co-ordinates and heading.

INPUT AND OUTPUT
Test Input:
5 5
1 2 N
LMLMLMLMM

Expected Output:
1 3 N


Test Input:
5 5
3 3 E
MMRMMRMRRM
 
Expected Output:
5 1 E
