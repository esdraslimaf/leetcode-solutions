/*
Este código implementa a solução para o problema "Two Sum" no LeetCode.
https://leetcode.com/problems/two-sum/
O problema requer encontrar os índices de dois números em um array que somam a um valor alvo.

Exemplo 1:
Entrada: nums = [2,7,11,15], target = 9
Saída: [0,1]
Explicação: Como nums[0] + nums[1] é igual a 9, retornamos [0, 1].
*/

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Itera pelos elementos do array para encontrar uma combinação que soma ao valor alvo.
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    // Retorna os índices dos dois números que somam ao valor alvo.
                    return new int[] { i, j };
                }
            }
        }
        // Se nenhuma combinação for encontrada, retorna null.
        return null;
    }
}






