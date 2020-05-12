# Change Maker App

## by Tyler Bates & Ethan Firpo (2020)

## Description

This site will calculate how many of each denomination is needed to make an inputted change amount with the least amount of coins.

## Setup

Install .NET. Type "dotnet run" in your console. Follow along.

## Technology

#### C#
#### .NET
#### MSTest

## Specs

|Behavior|Input|Output|
|-----|-----|-----|
|Program will accept user input for a decimal amount of change|.99|.99|
|Program will calculate the highest number of quarters that can go into that change|.99|3|
|Program will calculate how many dimes go into the remainder|.99|2|
|Program will calculate how many nickles go into the remainder of last function|.99|0|
|Program will calculate how many pennies go into the remainder of last function|.99|4|

## Legal

#### MIT License

### Copyright (c) 2020 Tyler Bates & Ethan Firpo

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
