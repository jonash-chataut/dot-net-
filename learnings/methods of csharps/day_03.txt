🧠 Day 3 of My C# Journey 🚀

Today, I focused entirely on methods — how they work, how data is passed between them, and the different ways to return results.
It’s amazing to see how much control methods give us over our code — not just to perform tasks, but also to manage how data flows.

Here’s what I explored and learned today 👇

💡 1. Methods: Building Blocks of Reusable Code
A method (also called a function) is a block of code designed to perform a specific task.
Instead of repeating logic multiple times, we can put it inside a method and call it whenever needed.

For example, a simple method like getsum() can add two numbers — keeping the Main() method clean and easy to follow.
This is a key principle in programming called modularity, which makes code reusable, organized, and easier to maintain.

💡 2. Passing Data into Methods (Parameters)
Methods often need data to work with. We send this data through parameters — the values we pass when calling a method.
In my program, I created a method getsum(int x, int y) that takes two integers and prints their sum.

This concept of “passing data into a method” is known as pass by value — meaning that the method gets a copy of the data, not the original variable. So changes inside the method don’t affect the original values.

💡 3. ref Keyword – Pass by Reference
Normally, methods can’t change the original variable’s value, because they only receive a copy.
But by using the ref keyword, we can pass the actual variable reference.
That means changes inside the method reflect directly in the original variable outside.

In my program, I created a method swapp(ref int x, ref int y) that swaps two numbers.
This showed how ref allows real-time modification of variables between methods — powerful but should be used carefully.

💡 4. out Keyword – Returning Data from Methods
Another new thing I learned is the out parameter, which is used when you want a method to return more than one value.
Unlike a normal return statement, out lets you send an extra result back through a parameter.

In my example, doubleit(int n, out int solution) takes a number and sends back its double using the out variable solution.
This concept is especially useful when a method needs to produce multiple results.

💡 5. params Keyword – Flexible Number of Arguments
Normally, methods expect a fixed number of parameters.
But using the params keyword, I can create methods that take any number of arguments.
Inside the method, these values are treated as an array.

For example, getsummore(params int[] nums) allows me to pass as many numbers as I want — like getsummore(1, 2, 3) or getsummore(1, 2, 3, 4, 5) — and it sums them all.
This makes the code more dynamic and adaptable.

💡 6. Type Conversion and Input Handling
I also used int.Parse() to convert text input from Console.ReadLine() into integers.
This is an essential part of handling user input since everything typed in the console starts as text.

💡 7. String Interpolation for Cleaner Output
Instead of concatenating strings with +, I used string interpolation — writing variables directly inside $"..." strings.
For example:
Console.WriteLine($"Sum is: {x + y}");
It’s a clean, modern, and readable way to mix text with variable values.

💭 Reflection:
Today’s session was all about understanding how data moves — how we pass it, modify it, and return it between methods.
Learning ref, out, and params made me realize how flexible C# can be when writing reusable and efficient code.

Each keyword I learned today gives me more control over logic and flow — small steps, but they make a huge difference in understanding how real-world programs are structured.

#Day3 #CSharp #ProgrammingBasics #LearningJourney #CodeNewbie #DotNet #Functions #Methods #LearnToCode #Programming
