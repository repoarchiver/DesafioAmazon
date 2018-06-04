using System;
using System.Collections.Generic;

namespace Amazon
{
    /// <summary>
    /// Michelle has created a word game for her students. The word game begins with Michelle writing a string and a number, K, on the board. The students have to find the substrings of size K with K distinct characters.
    /// Write an algorithm to help the students find the correct answer.If the given string does not have K distinct characters then output an empty list.
    /// Michelle criou um jogo de palavras para seus alunos. O jogo de palavras começa com Michelle escrevendo uma string e um número, K, no quadro. Os alunos têm que encontrar as substrings de tamanho K com K caracteres distintos.
    /// Escreva um algoritmo para ajudar os alunos a encontrar a resposta correta.Se a cadeia dada não tiver caracteres K distintos, em seguida, emita uma lista vazia.
    /// </summary>
    public class WorldGameMichelle
    {
        public List<string> subStringsKDist(string inputStr, int num)
        {
            List<string> substringDict = new List<string>();

            if (num < 0 || num > 26)
                return substringDict;

            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[a-z]+");
            if (!regex.IsMatch(inputStr))
                return substringDict;

            int index = 0;
            while (true)
            {
                string extractStr = inputStr.Substring(index, num);
                var extractStrOrdered = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.OrderBy(extractStr, x => x));

                bool accept = true;
                for (int i = 0; i < extractStrOrdered.Length - 1; i++)
                {
                    var letter = extractStrOrdered[i];
                    for (int j = i + 1; j < extractStrOrdered.Length; j++)
                    {
                        if (letter == extractStrOrdered[j])
                        {
                            accept = false;
                            break;
                        }
                    }

                    if (!accept)
                        break;
                }

                if (accept)
                {
                    if (!substringDict.Contains(extractStr))
                        substringDict.Add(extractStr);
                }

                index++;

                if ((index + num) > inputStr.Length)
                    break;
            }

            return substringDict;
        }
    }
}

