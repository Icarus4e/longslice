## Longslice
**  
Il problema richiede di trovare il prodotto più grande di una sottostringa contigua di lunghezza N all'interno di una stringa di cifre. Ad esempio, per la stringa "1027839564", il prodotto più grande per una serie di 3 cifre è 270 e per una serie di 5 cifre è 7560. Il compito è implementare un algoritmo che, data una stringa di cifre e un valore N, restituisca il prodotto massimo di una sottostringa di lunghezza N.**

## Soluzione
La soluzione consiste in due cicli for annidati: il primo ciclo for scorre la stringa di cifre dall'inizio alla fine, il secondo ciclo for, che è interno al primo, scorre ogni serie di cifre di lunghezza span all'interno della stringa di cifre. In ogni iterazione del secondo ciclo for, viene calcolato il prodotto delle cifre nella serie utilizzando l'operatore di moltiplicazione. Se il prodotto ottenuto è maggiore del più grande prodotto calcolato fino a quel momento, il prodotto diventa il nuovo più grande prodotto. Prima di iniziare i cicli for, il metodo effettua alcune verifiche: se la lunghezza della serie di cifre span è negativa o supera la lunghezza della stringa di cifre digits, il metodo lancia un'eccezione. Inoltre, se la serie di cifre contiene caratteri non numerici, il metodo lancia un'altra eccezione.

![Screenshot 2023-05-01 100246](https://user-images.githubusercontent.com/113766707/235426805-ab5f346b-2aa4-4669-8892-9697957bf984.png)
![Screenshot 2023-05-01 100159](https://user-images.githubusercontent.com/113766707/235426835-b9059f5d-dc6c-4b9a-8116-336563b7ed01.png)
