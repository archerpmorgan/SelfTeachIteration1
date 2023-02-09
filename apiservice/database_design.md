# Database Design

The SQLite database will have the following tables:

problem(
    name: String,
    completed: Boolean,
    completionDate: String
    section_id: int
    book_id: int
)

section(
    name: String, //usually a number, like 1, 13, etc, but can be an appendix name like AA or something
    haveStudied: Boolean,
    studiedDate: String,
    description: String, //usually the chapter name in the book, e.g. Vectors and Kinematics
    problemCount: Number,
    book_id: int
)

book(
    title: unique string
    subject: String,
    author: String,
    edition: String,
)

There is also a definition for an object containing all the information required to make a new book

newBookRequest
    title: String,
    subject: String,
    author: String,
    edition: String,
    sections: [section]
