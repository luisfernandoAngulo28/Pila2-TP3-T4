using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class clsPila2
    { //Atributos
        public const int MAX = 100;
        private int[] Pila = new int[MAX];
        public int top1;
        public int top2;
        public int cant;// cantidad de elementos en el arreglo
        //Constructor

        public clsPila2()
        {
            top1 = -1;
            top2 = MAX;
            cant = 0;
            for (int i = 0; i < MAX; i++)
            {
                Pila[i] = 0;
            }
        }

        public clsPila2(clsPila2 p)
        {
            top1 = p.top1;
            top2 = p.top2;
            cant = p.cant;
            for (int i = 0; i < MAX; i++)
            {
                Pila[i] = p.Pila[i];
            }
        }
        //Llena(S) -->  Boolean        
        // Retorna TRUE si S esta llena de lo contrario FALSE
        public bool Llena(int S)
        {
            bool b = false;
            if (S == 1)
            {
                if (top1 + 1 == MAX / 2)
                {
                    b = true;
                }
            }
            else
            {
                if (top2 - 1 == MAX / 2)
                {
                    b = true;
                }
            }
            return b;
        }

        //Vacia(S) --> Boolean       
        // Retorna TRUE si S esta vacía de lo contrario FALSE
        public bool Vacia(int S)
        {
            bool b = false;
            if (S == 1)//pila1
            {
                if (top1 == -1)
                {
                    b = true;
                }
            }
            else
            {//pila 2
                if (top2 == MAX)
                {
                    b = true;
                }
            }
            return b;
        }
        //Add(S,x) -->S 
        // Adiciona el elemento x la pila,
        public void Add(int S, int x)
        {
            if (S == 1)//pila1
            {
                if (!Llena(S))
                {
                    top1++;
                    Pila[top1] = x;
                    cant++;
                }
            }
            else
            {
                if (!Llena(S))
                {
                    top2--;
                    Pila[top2] = x;
                    cant++;
                }
            }
        }

        // Delete(S) -->S 
        // Elimina el elemento tope de la pila

        public void Delete(int S)
        {
            if (S == 1)
            {
                if (!Vacia(S))
                {
                    top1--;
                }
            }
            else
            {
                if (!Vacia(S))
                {
                    top2++;
                }
            }
        }

        //Mostrar

        public String Mostrar()
        {
            String S = "P[";
            for (int i = 0; i <= top1; i++)
            {
                S = S + Pila[i] + "|";
            }
            for (int i = top2; i < MAX; i++)
            {
                S = S + Pila[i] + "|";
            }
            S = S.Substring(0, S.Length - 1);//quita la ultimo palito
            return S + "]";
        }














    }
}
