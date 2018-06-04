# DesafioAmazon
Processo de seleção 2018 - Desafio lógica de programação - Amazon

**Some algoritmos has unit tests for executing.**

# Test 1 - Class: CalculateTrip => minimumNumberOfTrips
Without Description - I lost.

# Test 2 - Class: DroneDelivery => minimumNumberOfTrips
Without Description - I lost.

# Test 3 - Class: EightHousesCells => cellComplete

A colony of eight houses, represented as cells, are arranged in a straight line. Each day every cell competes with its adjacent cells (neighbours). An integer value of 1 represents an active cell and value of 0 represents an inactive cell. If both the neighbours are either active or inactive, the cell becomes inactive the next day; otherwise it becomes active on the next day. The two cells on the ends have a single adjacent cell, so the other adjacent cell can be assumed to be always inactive. Even after updating the cell state, its previous state is considered for updating the state of other cells. The cell information of all cells should be updated simultaneously.

# Test 4 - Class: GCDCalculator => generalizedGCD

The greatest common divisor (GCD), also called highest common factor (HCF) of N numbers is the largest positive integer that divides all numbers without giving a remainder.

Write an algorithm to determine the GCD of N positive integers.

# Test 5 - Class: WorldGameMichelle => subStringsKDist

Michelle has created a word game for her students. The word game begins with Michelle writing a string and a number, K, on the board. The students have to find the substrings of size K with K distinct characters.

Write an algorithm to help the students find the correct answer.If the given string does not have K distinct characters then output an empty list.

# Test description - Not Implemented
You are working on developing a movie with Amazon Video and want to devise an application to easily break up individual shots (short sequence from a particular camera angle) in a video into scenes (a sequence of shots).  Each shot is labeled with a letter. There is already an algorithm that breaks the video up into shots and labels them.

Write a function which will partition a sequence of shots into minimal subsequences so that no shot appears in more than one subsequence. The output should be the length of each subsequence. 

**Input**

The input to the function/method consists of an argument - inputList, a list of characters representing the sequence of shots.

**Output**

Return a list of integers representing the length of each scene, in the order in which it appears in the given sequence of shots.

Example 1:

inputList = [a, b, c]

Output = [1, 1, 1]

Explanation:
Because there are no recurring shots, all shots can be in the minimal length 1 subsequence.

Example 2:

inputList  = [a, b, c, a]

Output = [4]

Explanation:
Because ‘a’ appears more than once, everything between the first and last appearance of ‘a’ must be in the same list.

Example 3:
inputList = [a, b, a, b, c, b, a, c, a, d, e, f, e, g, d, e, h, i, j, h, k, l, i, j]

Output = [9, 7, 8]

Test 1:
Input = [a, b, c, d, a, e, f, g, h, i, j, e]

Output = 5 7

Test 2:
[z, z, c, b, z, c, h, f, i, h, i]

Output = 6 5

-----------------------

For some algoritmos, I used other technique for get feature LINQ, because the Amazon platform don't was let me include the others namespaces.

Sorry for my English.