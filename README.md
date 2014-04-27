# grammar-generator #

It is a command line tool for generating grammar syntax file (*g extension*) and grammar template file (*stg extension*) from definition files (*input extension*) using them like kind of *schema*. In next step ANTLR uses both files for generating lexer and parser in *C#* - generated code is a DSL-to-SQL translator.

Input files defines grammar for internal, domain specific language for filtering. It is implementation of my Bachelor of Science Thesis (title: *Metaprogrammable internal query language to SQL query translator*). Whole project is written in *Test-Driven Development* style.

Source code is licensed on MIT License.

Technologies and languages used in project:

- python (*2.7.x*)
- ANTLR
- JSON (*for input files*)
