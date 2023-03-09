# oop-lesson5-eightball

This is a C# program that simulates a magic eight ball game. Here's how the program works:

The program creates an instance of the Random class and generates a random integer between 1 and 20 using the Next method.

The program creates an ArrayList called myAnswers and populates it with 20 possible answers. The first 10 answers are positive, the next 5 are non-committal, and the last 5 are negative.

The program uses the random integer generated in step 1 to select an answer from the myAnswers ArrayList using the indexing syntax myAnswers[randomNumber].

The selected answer is then displayed to the console, along with some decorative asterisks.

The program essentially works as a magic eight ball game, where the user asks a yes-or-no question and shakes the eight ball to receive a random answer. The program randomly selects an answer from a list of possible answers and displays it to the user.
