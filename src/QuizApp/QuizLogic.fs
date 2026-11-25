module QuizLogic

open Domain

// TODO (Teammate 2): Use function composition (>>) to trim and lowercase strings
let normalize (text: string) : string = failwith "TODO: Implement normalize"
let login (username: string) (password: string) (state: AppState) : AppState = failwith "TODO: Implement login"
let signUpStudent (username: string) (password: string) (state: AppState) : AppState = failwith "TODO: Implement signUpStudent"
let logout (state: AppState) : AppState = failwith "TODO: Implement logout"
let validateNewQuestion (prompt: string) (points: int) : Result<string * int, string> = failwith "TODO: Implement validateNewQuestion"
let addQuestion (prompt: string) (kind: QuestionKind) (points: int) (correctAnswer: AnswerValue) (state: AppState) : AppState = failwith "TODO: Implement addQuestion"
let checkAnswer (expected: AnswerValue option) (actual: AnswerValue option) : bool = failwith "TODO: Implement checkAnswer"
let computeScore (state: AppState) : int * int = failwith "TODO: Implement computeScore"
let submitAnswer (answer: AnswerValue) (state: AppState) : AppState = failwith "TODO: Implement submitAnswer"
let restartQuiz (state: AppState) : AppState = failwith "TODO: Implement restartQuiz"
