open System.IO

let readFile (streamReader: StreamReader) =
    streamReader.ReadToEnd()

let readFromFile (fileName: string) =
    using(new StreamReader(fileName)) readFile 
    
readFromFile "TestFile.txt"
|> printf "%A"