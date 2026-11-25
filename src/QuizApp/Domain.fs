module Domain

type Role =
    | Admin
    | Student

type User = { Username: string; Password: string; Role: Role }

type QuestionKind =
    | MultipleChoice of options: Map<int, string>
    | Written

type Question = { Id: int; Prompt: string; Kind: QuestionKind; Points: int }

type AnswerValue =
    | OptionIndex of int
    | WrittenText of string

type Screen = LoginScreen | AdminDashboard | StudentQuizScreen

type QuizSession = { UserAnswers: Map<int, AnswerValue>; CurrentPos: int; IsCompleted: bool }

type AppState = {
    Users: Map<string, User>
    CurrentUser: User option
    CurrentScreen: Screen
    Questions: Map<int, Question>
    CorrectAnswers: Map<int, AnswerValue>
    QuestionOrder: int list
    Quiz: QuizSession
    StatusMessage: string option
}
