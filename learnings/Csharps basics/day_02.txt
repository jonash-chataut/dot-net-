🧠 Day 2 of My C# Journey 🚀

Today, I went a bit deeper into C# basics — exploring data ranges, functions, and command-line arguments. Even though the program looks small, it opened the door to several powerful concepts that form the foundation of every real C# application.

Here’s what I learned today 👇

💡 1. The Role of the Main() Method
In C#, the Main() method is still the entry point of the program — that’s where execution starts.
But today, I discovered that it can also accept arguments (known as args), which are values passed when the program runs.

For example, if you run your program with values like 1 2 3 4 5, they get stored in the args array. You can access them using a loop — allowing the program to process user inputs given at runtime.

This taught me how command-line arguments can make programs dynamic — they allow external data to flow into the program without changing the code.

💡 2. Arrays and the for Loop
I used a for loop to go through each item in the args array.
A for loop runs a block of code multiple times — perfect for repetitive tasks. It has three parts:

Initialization (e.g., int i = 0;)

Condition (e.g., i < args.Length;)

Increment/Update (e.g., i++)

Arrays and loops often go hand-in-hand because arrays store multiple values, and loops help process each one efficiently.

💡 3. Methods (Functions) and Code Reuse
I created a separate method called sayhola().
Methods help you organize your code — instead of writing the same logic inside Main() again and again, you can define it once and “call” it whenever needed.

Defining your own methods makes your code cleaner, more readable, and easier to maintain — one of the core principles of modular programming.

I also learned about access modifiers — here, I used private static:

private means the method is only accessible inside the same class.

static means the method belongs to the class itself, not to a specific object (so we can call it directly from Main() without creating an instance).

💡 4. Console.WriteLine() and Placeholders
Instead of concatenating strings with +, today I learned another way to print variables inside text using placeholders:

Console.WriteLine("Biggest integer is: {0}", int.MaxValue);

Here, {0} is replaced by the first variable after the comma. You can use multiple placeholders like {0}, {1}, etc. This makes your print statements cleaner and easier to format.

💡 5. Integer Limits (int.MaxValue and int.MinValue)
C# has defined limits for how large or small an integer can be.

int.MaxValue gives the largest possible value an integer can hold (2,147,483,647).

int.MinValue gives the smallest possible value (-2,147,483,648).

Understanding data ranges is essential when dealing with large numbers or memory optimization — it helps avoid overflow errors where numbers exceed their limits.

💡 6. Comments and Code Organization
I also used both single-line comments (//) and multi-line comments to document my code.
Writing comments may not change how a program runs, but it’s an excellent habit — it helps others (and your future self) understand why something is written a certain way.

💭 Reflection:
Today’s session taught me how even small features like functions, loops, and placeholders make programs structured and efficient. I also got my first real look at how data flows through a program — from command-line inputs to variables and methods.

Each new keyword and concept is starting to connect into a bigger picture of how C# really works.

#Day2 #CSharp #LearningJourney #CodingForBeginners #DotNet #Programming #CodeNewbie #LearnToCode
