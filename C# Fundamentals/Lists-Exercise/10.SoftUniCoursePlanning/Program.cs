List<string> lessons = Console.ReadLine()
    .Split(", ")
    .ToList();

string commnds;

while ((commnds = Console.ReadLine()) != "course start")
{
    string[] arguments = commnds.Split(":");

    if (arguments[0] == "Add")
    {
        string lessonTitle = arguments[1];

        if (lessons.Exists(x => x != lessonTitle))
        {
            lessons.Add(arguments[1]);
        }
    }
    else if (arguments[0] == "Insert")
    {
        string lessonTitle = arguments[1];
        int index = int.Parse(arguments[2]);

        if (lessons.Exists(x => x == lessonTitle))
        {
            continue;
        }
        else
        {
            lessons.Insert(index, lessonTitle);

        }
    }
    else if (arguments[0] == "Remove")
    {
        string lessonTitle = arguments[1];

        if (lessons.Exists(x => x == lessonTitle))
        {
            lessons.Remove(lessonTitle);
        }
        if (lessons.Exists(x => x == lessonTitle + "-Exercise"))
        {
            lessons.Remove(lessonTitle + "-Exercise");
        }
    }
    else if (arguments[0] == "Swap")
    {
        string lessonTitleOne = arguments[1];
        string lessonTitleTwo = arguments[2];

        if (lessons.Contains(lessonTitleOne) && lessons.Contains(lessonTitleTwo))
        {
            int firstLessonIndex = lessons.IndexOf(lessonTitleOne);
            int secondLessonIndex = lessons.IndexOf(lessonTitleTwo);

            lessons[firstLessonIndex] = lessonTitleTwo;
            lessons[secondLessonIndex] = lessonTitleOne;

            if (lessons.Contains($"{lessonTitleOne}-Exercise"))
            {
                lessons.Insert(secondLessonIndex + 1, $"{lessonTitleOne}-Exercise");
                lessons.RemoveAt(firstLessonIndex + 2);
            }

            if (lessons.Contains($"{lessonTitleTwo}-Exercise"))
            {
                lessons.Insert(firstLessonIndex + 1, $"{lessonTitleTwo}-Exercise");
                lessons.RemoveAt(secondLessonIndex + 2);
            }
        }
    }
    else if (arguments[0] == "Exercise")
    {
        string lessonTitle = arguments[1];
        string exercise = $"{lessonTitle}-Exercise";

        if (!lessons.Contains(exercise))
        {
            if (lessons.Contains(lessonTitle))
            {
                int indexLesson = lessons.IndexOf(lessonTitle);
                lessons.Insert(indexLesson + 1, exercise);
            }
            else
            {
                lessons.Add(lessonTitle);
                lessons.Add(exercise);
            }
        }
    }
}

for (int i = 0; i < lessons.Count; i++)
{
    Console.WriteLine($"{i + 1}.{lessons[i]}");
}