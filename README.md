# HCLTech .NET Full Stack Training

A phase-wise learning repository for organizing notes, practice code, assignments, revision, and assessments throughout HCLTech .NET Full Stack training. It is designed to grow with the training: add focused examples and projects as you learn, without committing build output, local settings, or secrets.

## Training Objectives

- Build a strong foundation in C# and modern .NET development.
- Practice relational database design and SQL.
- Develop secure web applications and APIs with ASP.NET Core.
- Build front ends with Angular and TypeScript and integrate them with .NET APIs.
- Learn testing, code quality, microservices, containers, and CI/CD.
- Consolidate the learning in a full-stack capstone and prepare for assessments and placement interviews.

## Technologies Covered

- C# and .NET
- SQL and relational databases
- ASP.NET Core and web security
- Testing and code quality
- Angular and TypeScript
- Full-stack integration and microservices
- Docker and CI/CD

## Learning Roadmap

| Phase | Topics |
|---|---|
| 01 | C# fundamentals: introduction, variables and data types, operators, conditionals, loops, methods, arrays and strings, OOP, and exception handling |
| 02 | Modern C#: collections, generics, LINQ, delegates and events, and async/await |
| 03 | SQL and databases |
| 04 | ASP.NET Core |
| 05 | ASP.NET security |
| 06 | Testing and code quality |
| 07 | Angular and TypeScript |
| 08 | Full-stack integration |
| 09 | Microservices |
| 10 | Docker and CI/CD |
| 11 | Capstone |

## Repository Structure

```text
.
├── README.md
├── .gitignore
├── Phase-01-CSharp-Fundamentals/
│   ├── 01-Introduction/
│   ├── 02-Variables-and-DataTypes/
│   ├── 03-Operators/
│   ├── 04-Conditional-Statements/
│   ├── 05-Loops/
│   ├── 06-Methods/
│   ├── 07-Arrays-and-Strings/
│   ├── 08-OOP/
│   ├── 09-Exception-Handling/
│   ├── Notes.md
│   └── Assignments.md
├── Phase-02-Modern-CSharp/
│   ├── Collections/
│   ├── Generics/
│   ├── LINQ/
│   ├── Delegates-and-Events/
│   ├── Async-Await/
│   └── Notes.md
├── Phase-03-SQL-and-Database/
├── Phase-04-ASP.NET-Core/
├── Phase-05-ASP.NET-Security/
├── Phase-06-Testing-and-Code-Quality/
├── Phase-07-Angular-and-TypeScript/
├── Phase-08-FullStack-Integration/
├── Phase-09-Microservices/
├── Phase-10-Docker-and-CICD/
├── Phase-11-Capstone/
├── Revision/
└── Assessments/
    ├── Assessment-01/
    ├── Assessment-02/
    ├── Assessment-03/
    ├── Assessment-04/
    └── Assessment-05/
```

Each phase has a `Notes.md` starter. Add examples and practice projects in the corresponding topic folder. Use `Revision/` for concise cross-phase summaries, flashcards, and topics to revisit. Assessment folders are ready for assessment-specific instructions, submissions, and review notes.

## Progress Tracking

- [ ] Phase 01 — C# Fundamentals
- [ ] Phase 02 — Modern C#
- [ ] Phase 03 — SQL and Database
- [ ] Phase 04 — ASP.NET Core
- [ ] Phase 05 — ASP.NET Security
- [ ] Phase 06 — Testing and Code Quality
- [ ] Phase 07 — Angular and TypeScript
- [ ] Phase 08 — Full-Stack Integration
- [ ] Phase 09 — Microservices
- [ ] Phase 10 — Docker and CI/CD
- [ ] Phase 11 — Capstone

## Assessment Tracking

- [ ] Assessment 01
- [ ] Assessment 02
- [ ] Assessment 03
- [ ] Assessment 04
- [ ] Assessment 05

Update these checklists as you complete each phase or assessment. Record detailed outcomes and follow-up topics in the relevant phase notes.

## Running C# Programs

The topic folders are intentionally empty to start; no .NET projects are created yet. When ready to practice, install the .NET SDK, open a terminal in the relevant topic folder, and create a console project:

```bash
dotnet new console -n Practice
cd Practice
dotnet run
```

Run later sessions from the project directory with `dotnet run`. Keep source code and project files in the repository; generated `bin/` and `obj/` output is ignored.

## Git Workflow

Use small, descriptive commits to keep a record of your learning:

```bash
git status
git add Phase-01-CSharp-Fundamentals
git commit -m "Add C# fundamentals practice"
git push
```

Before committing, review `git status` and ensure no credentials, environment files, or generated output are included. Use a new branch for larger exercises or capstone work, then merge it when complete.