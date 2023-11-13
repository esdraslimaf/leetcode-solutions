/* 
Este código implementa a solução para o problema "Single Number" no LeetCode.
https://leetcode.com/problems/single-number/

Dado um array não vazio de números inteiros 'nums', cada elemento aparece duas vezes, exceto por um. Encontre esse único elemento.

Exemplo 1:
Entrada: nums = [2,2,1]
Saída: 1

Exemplo 2:
Entrada: nums = [4,1,2,1,2]
Saída: 4

Exemplo 3:
Entrada: nums = [1]
Saída: 1
*/

public class Solution {
    public int SingleNumber(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            int count = 0;

            for (int j = 0; j < nums.Length; j++) {
                if (nums[i] == nums[j]) {
                    count++;
                }
            }
            if (count == 1) {
                return nums[i];
            }
        }
        return -1; //Caso não exista número isolado 
    }
}
