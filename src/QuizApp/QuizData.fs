module QuizData

open Domain

let emptySession : QuizSession = {
    UserAnswers = Map.empty
    CurrentPos = 0
    IsCompleted = false
}

// TODO (Teammate 1): Pre-seed default admin ("admin" / "admin123") and starter MCQ + Written questions
let initialState : AppState =
    failwith "TODO: Implement initialState"
