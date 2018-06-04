using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    /// <summary>
    /// A colony of eight houses, represented as cells, are arranged in a straight line. Each day every cell competes with its adjacent cells (neighbours). An integer value of 1 represents an active cell and value of 0 represents an inactive cell. If both the neighbours are either active or inactive, the cell becomes inactive the next day; otherwise it becomes active on the next day. The two cells on the ends have a single adjacent cell, so the other adjacent cell can be assumed to be always inactive. Even after updating the cell state, its previous state is considered for updating the state of other cells. The cell information of all cells should be updated simultaneously.
    /// Uma colônia de oito casas, representadas como células, está disposta em linha reta. Cada dia, cada célula compete com as células adjacentes (vizinhos). Um valor inteiro de 1 representa uma célula ativa e o valor de 0 representa uma célula inativa. Se ambos os vizinhos estiverem ativos ou inativos, a célula fica inativa no dia seguinte; Caso contrário, ele fica ativo no dia seguinte. As duas células nas extremidades possuem uma única célula adjacente, de modo que a outra célula adjacente pode ser presumida estar sempre inativa. Mesmo depois de atualizar o estado da célula, seu estado anterior é considerado para atualizar o estado de outras células. A informação da célula de todas as células deve ser atualizada simultaneamente.
    /// </summary>
    public class EightHousesCells
    {

        public int[] cellComplete(int[] states, int days)
        {
            int leftNeighbor = 0;
            int rightNeighbor = 0;
            int[] previousState = null;

            for (int i = 0; i < days; i++)
            {
                previousState = states.Clone() as int[];
                for (int j = 0; j < states.Length; j++)
                {
                    if (j == 0)
                    {
                        leftNeighbor = 0;
                        rightNeighbor = previousState[j + 1];
                    }
                    else if (j == states.Length - 1)
                    {
                        leftNeighbor = previousState[j - 1];
                        rightNeighbor = 0;
                    }
                    else
                    {
                        leftNeighbor = previousState[j - 1];
                        rightNeighbor = previousState[j + 1];
                    }

                    states[j] = 1;
                    if (leftNeighbor == rightNeighbor)
                        states[j] = 0;
                }
            }

            return states;
        }
    }
}
