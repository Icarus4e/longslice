## Longslice
**  
Il problema richiede di trovare il prodotto più grande di una sottostringa contigua di lunghezza N all'interno di una stringa di cifre. Ad esempio, per la stringa "1027839564", il prodotto più grande per una serie di 3 cifre è 270 e per una serie di 5 cifre è 7560. Il compito è implementare un algoritmo che, data una stringa di cifre e un valore N, restituisca il prodotto massimo di una sottostringa di lunghezza N.**

## Soluzione
La soluzione consiste in due cicli for annidati: il primo ciclo for scorre la stringa di cifre dall'inizio alla fine, il secondo ciclo for, che è interno al primo, scorre ogni serie di cifre di lunghezza span all'interno della stringa di cifre. In ogni iterazione del secondo ciclo for, viene calcolato il prodotto delle cifre nella serie utilizzando l'operatore di moltiplicazione. Se il prodotto ottenuto è maggiore del più grande prodotto calcolato fino a quel momento, il prodotto diventa il nuovo più grande prodotto. Prima di iniziare i cicli for, il metodo effettua alcune verifiche: se la lunghezza della serie di cifre span è negativa o supera la lunghezza della stringa di cifre digits, il metodo lancia un'eccezione. Inoltre, se la serie di cifre contiene caratteri non numerici, il metodo lancia un'altra eccezione.


    using System;
    
    public static class LargestSeriesProduct
    {
      public static long GetLargestProduct(string digits, int span)
      {
        // Controlla se lo span è negativo o più grande della lunghezza della stringa digits.
        if (span < 0 || span > digits.Length)
        {
            throw new ArgumentException("Non e valido");
        }
        
        // Se lo span è uguale a zero, restituisce 1.
        if (span == 0)
        {
            return 1;
        }
        
        // Variabile per tenere traccia del prodotto più grande trovato finora.
        long largestProduct = 0;
        
        // Cicla su tutti i possibili sottoinsiemi di span numeri consecutivi all'interno di digits.
        for (int i = 0; i <= digits.Length - span; i++)
        {
            // Variabile per tenere traccia del prodotto della sequenza corrente.
            long product = 1;
            
            // Cicla sui singoli numeri della sequenza corrente.
            for (int j = 0; j < span; j++)
            {
                // Prende il j-esimo carattere della sequenza corrente.
                char c = digits[i + j];
                
                // Se il carattere non è un numero, lancia un'eccezione.
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("Span con caratteri invalido");
                }
                
                // Calcola il prodotto moltiplicando il valore numerico del carattere per il prodotto corrente.
                product *= (long)(c - '0');
            }
            
            // Se il prodotto corrente è più grande del prodotto più grande trovato finora, lo aggiorna.
            if (product > largestProduct)
            {
                largestProduct = product;
            }
        }
        
        // Restituisce il prodotto più grande trovato.
        return largestProduct;
      } 
    }
