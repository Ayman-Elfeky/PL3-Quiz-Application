# PL-3 Functional Quiz Application (F# & Windows Forms)

A pure functional desktop Quiz Application built with **F# (.NET 8)** and **Windows Forms**, featuring role-based authentication (**Admin** and **Student**), dynamic question creation (**Multiple Choice** and **Written**), local JSON persistence, and automated unit testing.

---

## Features

- **Role-Based Authentication:**
  - **Admin Portal (`admin` / `admin123`):** Log in to create new Multiple Choice (up to 4 options) or Written questions, assign custom point values, set correct answers, and log out.
  - **Student Portal:** Sign up with a new student account or log in to take the quiz built from the admin's questions.
- **Automated Grading & Feedback:**
  - Exact option matching for Multiple Choice questions.
  - Case-insensitive, whitespace-trimmed matching for Written questions.
  - Real-time progress tracking and final score breakdown (`earned / total` points and percentage) with quiz retake support.
- **JSON Persistence:** Automatically saves registered student accounts and admin-created questions to `quiz_store.json` across sessions.

---

## Functional Programming Architecture

This project avoids `mutable` state and imperative loops in favor of idiomatic F# functional patterns:

- **Algebraic Data Types (ADTs):** Discriminated Unions (`Role`, `QuestionKind`, `AnswerValue`, `Screen`, `Msg`) and immutable Records (`User`, `Question`, `QuizSession`, `AppState`) make illegal application states unrepresentable[cite: 6].
- **Persistent Collections:** Uses immutable F# `Map` and `List` structures for users, questions, correct answers, and submitted responses[cite: 5, 6].
- **Exhaustive Pattern Matching:** Handles authentication routing, role authorization, question rendering, and answer evaluation cleanly without `if/else` chains[cite: 6].
- **Higher-Order Functions & Pipelines:** Uses `Map.fold` for score calculation, `Map.tryPick` for UI option extraction, and `|>` pipelines for state transformations[cite: 6].
- **Functional Reactive UI (`Observable.scan`):** Manages the Windows Forms UI state as a pure fold over merged button click event streams (`Model -> Msg -> Model`) with zero `mutable` variables[cite: 6].

---

## Project Structure

```text
PL3-QuizApp/
├── .gitignore
├── README.md
├── PL3-QuizApp.sln
├── src/
│   └── QuizApp/
│       ├── QuizApp.fsproj      # .NET 8 Windows Forms project configuration
│       ├── Domain.fs           # Immutable Records & Discriminated Unions
│       ├── QuizData.fs         # Initial admin account & starter question bank
│       ├── QuizLogic.fs        # Pure auth, question creation, and scoring engine
│       ├── Storage.fs          # JSON serialization/deserialization boundary
│       └── Program.fs          # Windows Forms UI driven by Observable.scan
└── tests/
    └── QuizApp.Tests/
        ├── QuizApp.Tests.fsproj
        └── QuizLogicTests.fs   # xUnit tests for auth, permissions, and scoring