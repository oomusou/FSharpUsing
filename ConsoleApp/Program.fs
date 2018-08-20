open System.IO

let readFromFile (fileName: string) = 
    use streamReader = new StreamReader(fileName)
    streamReader.ReadToEnd()
    
readFromFile "TestFile.txt"
|> printf "%A"   