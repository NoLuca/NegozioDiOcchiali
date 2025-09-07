# NegozioDiOcchiali

## 📝 Breve descrizione
L’applicazione è un **negozio virtuale di occhiali** realizzato in Unity, dove gli utenti possono:

- Sfogliare un catalogo di occhiali.  
- Filtrare e ordinare gli occhiali per marca, forma, colore o prezzo.  
- Aggiungere articoli al carrello e completare l’ordine.  
- Provare virtualmente gli occhiali tramite webcam usando **Google MediaPipe Face Mesh**.  

---

## 🛠 Tecnologie utilizzate

- **Unity 6.0** – motore di gioco e interfaccia utente.  
- **C#** – linguaggio di programmazione.  
- **Google MediaPipe Unity Plugin v0.16.1** – riconoscimento del volto.  
- **JSON** – archiviazione dati catalogo e ordini.  
- **Prefab e UI Toolkit di Unity** – gestione interfaccia e componenti riutilizzabili.

---

## 📂 Classi principali e loro ruolo

| Classe | Ruolo |
|--------|-------|
| `Glasses` | Modello dati per gli occhiali (marca, colore, forma, prezzo, prefab 3D) |
| `CartItem` | Articolo nel carrello con quantità |
| `Order` | Ordine effettuato dall’utente, con articoli e totale |
| `User` | Dati utente (login, preferiti, ordini) |
| `UserService` | Login utente |
| `SimpleGlassesRig` | Posiziona e scala gli occhiali 3D sul volto usando Face Mesh |

---

### 📊 Diagramma UML 
![UML Negozio di occhiali](https://github.com/user-attachments/assets/fc7afeec-a12f-4e79-9df6-e69d6854665c)

