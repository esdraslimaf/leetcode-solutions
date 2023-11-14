/* 
Este código implementa duas soluções para o problema "Reverse String" no LeetCode.
https://leetcode.com/problems/reverse-string

Explicação do problema:
Escreva uma função que inverta uma string. A entrada é fornecida como um array de caracteres s.

Example 1:
Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

Example 2:
Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]
*/

// Solução 1: Reversão manual sem usar Array.Reverse (Propósito educacional).
public class Solution {
   public void ReverseString(char[] s)
 {                   
            int tamanhoarray = s.Length;
            int diminuir = tamanhoarray-1;
            char[] novoarray = new char[tamanhoarray];
            
            for(int i = 0; i < tamanhoarray; i++)
            {
                novoarray[i] = s[i];
            }

            for(int i = 0;i < novoarray.Length; i++)
            {
                s[i]= novoarray[diminuir];
                diminuir--;
            }
 }
}

// Solução 2: Reversão utilizando Array.Reverse (Abordagem simplificada).
public class Solution {
   public void ReverseString(char[] s)
 {                     
          Array.Reverse(s);
 }
}



