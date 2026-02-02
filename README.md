# 🖋️ Blog2 API & CLI System

![.NET Version](https://img.shields.io/badge/.NET-9.0-blueviolet)
![Interface](https://img.shields.io/badge/UI-Console%20Menu-green)


## 📖 Présentation
Ce projet est un système de blog complet. Il contient une  **Interface Console (CLI)** pour l'administration rapide des articles et des commentaires.

---

## 💻 Interface d'Administration (Console UI)
Le projet inclut un menu interactif situé dans `Developpemlent_blog3.UI.ConsoleMenu`. Cet outil permet de gérer des données chargées en memoire 
sans passer par une base de donnée.

### Fonctionnalités de la Console :
1.  **Lister les articles** : Affiche les IDs et titres de tous les articles.
2.  **Gestion des Articles** :
    * `Créer` : Ajout rapide avec titre et contenu.
    * `Voir` : Affiche les détails complets d'un article (via `ToString()`).
    * `Modifier` : Mise à jour du texte d'un article existant.
    * `Supprimer` : Suppression définitive par ID.
3.  **Gestion des Commentaires** :
    * `Ajouter` : Permet de lier un commentaire à un article spécifique.
    * `Supprimer` : Modération des commentaires par leur ID unique.



---

## 🛠️ Architecture du Code (UI)

La classe `ConsoleMenu` utilise le pattern **Service Injection** pour interagir avec les données :

* **Services utilisés** : `ArticleServices` et `CommentServices`.
* **Boucle de contrôle** : Utilisation d'un `while(true)` avec un `switch case` pour une navigation fluide.
* **Sécurité** : Validation des entrées utilisateurs via `int.TryParse` pour éviter les plantages lors de la saisie des IDs.

---

## 🚀 Comment lancer l'interface Console ?
Pour exécuter le menu d'administration, assurez-vous que votre méthode `Main` dans `Program.cs` appelle la classe UI :

```csharp
using Developpemlent_blog3.UI;

var menu = new ConsoleMenu();
menu.Show();
