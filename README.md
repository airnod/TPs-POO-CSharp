# 🧩 Travaux Pratiques — Programmation Orientée Objet (POO) C# .NET

> **Formation :** BTS Services Informatiques aux Organisations (SIO)  
> **Option :** Solutions Logicielles et Applications Métier (SLAM)  
> **Auteur :** Dorian Loron Morra  
> **Environnement :** C# (.NET / Visual Studio), Windows Forms (WinForms), DLLs de bibliothèque de classes

---

## 📌 Présentation Générale

Ce dépôt regroupe l'ensemble des Travaux Pratiques progressifs réalisés dans le cadre du module de **Programmation Orientée Objet (POO)** en C#. Les applications sont développées avec le framework **.NET** et l'interface graphique **Windows Forms**.

L'objectif pédagogique est d'assimiler les piliers de la POO, la modularité par librairies dynamiques (`.dll`), la manipulation de collections génériques (`List<T>`), ainsi que la conception d'interfaces événementielles multi-formulaires.

---

## 🗺️ Progression Pédagogique des TPs

```
TPs-POO-CSharp/
├── TP1-Objet-Unique/              # TP 1 : Manipulation d'un objet métier unique & intégration de DLL
├── TP2-Objets-Multiples/          # TP 2 : Association et composition entre plusieurs classes métiers
├── TP3-Gestion-Pays/              # TP 3 : Utilisation de collections génériques (List<T>) & DataGridView
├── TP3Bis-Gestion-Continents/     # TP 3bis : Agrégation complexe, architecture multi-formulaires & recherche
└── Documentation-Cours/           # Supports de cours et travaux dirigés théoriques
```

---

## 📝 Détail des Travaux Pratiques

### 1️⃣ TP 1 — Objet Unique (`TP1-Objet-Unique`)
- **Concepts :** Instanciation d'un objet métier (`pays`), appel des constructeurs avec paramètres, utilisation des accesseurs (`get`) et mutateurs (`set`), calcul de propriétés dérivées (`superfhab()`).
- **Composants :** Formulaire WinForms avec `TextBox`, `ComboBox`, `Label`, `Button` et `MessageBox`.
- **Intégration :** Référencement et consommation d'une bibliothèque compilée externe (`tp1dll.dll`).

### 2️⃣ TP 2 — Association d'Objets (`TP2-Objets-Multiples`)
- **Concepts :** Composition d'objets (la classe `pays` encapsule désormais un objet de type `monnaie`).
- **Gestion des relations :** Instanciation imbriquée, manipulation de sous-objets, modification à la volée du taux de change et de l'intitulé de la devise.
- **Intégration :** Consommation de `tp2dll.dll`.

### 3️⃣ TP 3 — Collections et Listes d'Objets (`TP3-Gestion-Pays`)
- **Concepts :** Manipulation d'une collection générique `List<pays>`, itération via boucles `foreach`, algorithmes d'agrégation (somme des habitants, recherche du maximum).
- **Interface dynamique :** Affichage des objets dans un composant `DataGridView` (`grdPays`), gestion des événements de sélection de cellule pour afficher le détail (`ToString()`), filtrage par devise.

### 4️⃣ TP 3bis — Architecture Multi-Formulaires & Agrégation (`TP3Bis-Gestion-Continents`)
- **Concepts :** Classe conteneur `continent` gérant une liste interne de pays (`lespays`), partage d'état global via une classe statique (`varglobale`), navigation entre formulaires modaux (`Form1` et `FrmPays`).
- **Fonctionnalités avancées :** Calcul de statistiques continentales (population totale, superficie cumulée, moyenne d'habitants par pays, pays le plus peuplé), recherche unitaire d'un pays par son nom (`rechpays`), mise à jour dynamique.

---

## 🏷️ Releases GitHub

Chaque étape de la progression fait l'objet d'une release dédiée avec son code source finalisé et ses explications :
- **`TP1-POO`** : Révision de la POO, classe `pays`, instanciation et DLL.
- **`TP2-POO`** : Composition de classes (`pays` et `monnaie`), gestion de devises.
- **`TP3-POO`** : Collections génériques `List<T>`, intégration `DataGridView` et calculs statistiques.
- **`TP3Bis-POO`** : Modèle complet continent/pays, multi-formulaires et recherche.
