# Create directroy 'Lesson_05'
mkdir Lesson_05

cd Lesson_05

dotnet new sln --name Lesson_05

mkdir Lesson_05.Console
mkdir Lesson_05.Lib

dotnet add Lesson_05.Console/Lesson_05.Console.csproj reference Lesson_05.Lib/Lesson_05.Lib.csproj