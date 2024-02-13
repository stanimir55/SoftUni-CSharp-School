List<string> lessonsAndExercises = Console.ReadLine()
    .Split(", ")
    .ToList();

string commands;
while ((commands = Console.ReadLine()) != "course start")
{
    string[] arguments = commands.Split(":");

    switch (arguments[0])
    {
        case "Add":
            string addLessonTitle = arguments[1];
            if (!lessonsAndExercises.Contains(addLessonTitle))
            {
                lessonsAndExercises.Add(addLessonTitle);
            }
            break;
        case "Insert":
            string insertLessonTitle = arguments[1];
            int index = int.Parse(arguments[2]);
            if (!lessonsAndExercises.Contains(insertLessonTitle))
            {
                lessonsAndExercises.Insert(index, insertLessonTitle);
            }
            break;
        case "Remove":
            string removeLessonTitle = arguments[1];
            if (lessonsAndExercises.Contains(removeLessonTitle))
            {
                lessonsAndExercises.Remove(removeLessonTitle);
            }
            break;
        case "Swap":
            string swapLessonTitle = arguments[1];
            string lessonTitle = arguments[2];

            if (lessonsAndExercises.Contains(swapLessonTitle) && lessonsAndExercises.Contains(lessonTitle))
            {
                int firstLessonIndex = lessonsAndExercises.IndexOf(swapLessonTitle);
                int secondLessonIndex = lessonsAndExercises.IndexOf(lessonTitle);

                lessonsAndExercises[firstLessonIndex] = lessonTitle;
                lessonsAndExercises[secondLessonIndex] = swapLessonTitle;

                if (lessonsAndExercises.Contains($"{swapLessonTitle}-Exercise"))
                {
                    lessonsAndExercises.Insert(secondLessonIndex + 1, $"{swapLessonTitle}-Exercise");
                    lessonsAndExercises.RemoveAt(firstLessonIndex + 2);
                }

                if (lessonsAndExercises.Contains($"{lessonTitle}-Exercise"))
                {
                    lessonsAndExercises.Insert(firstLessonIndex + 1, $"{lessonTitle}-Exercise");
                    lessonsAndExercises.RemoveAt(secondLessonIndex + 2);
                }
            }
            break;
        case "Exercise":
            string title = arguments[1];
            string exercise = $"{title}-Exercise";

            if (!lessonsAndExercises.Contains(exercise))
            {
                if (lessonsAndExercises.Contains(title))
                {
                    int indexLesson = lessonsAndExercises.IndexOf(title);
                    lessonsAndExercises.Insert(indexLesson + 1, exercise);
                }
                else
                {
                    lessonsAndExercises.Add(title);
                    lessonsAndExercises.Add(exercise);
                }
            }
            break;
    }
}

for (int i = 0; i < lessonsAndExercises.Count; i++)
{
    Console.WriteLine($"{i + 1}.{lessonsAndExercises[i]}");
}