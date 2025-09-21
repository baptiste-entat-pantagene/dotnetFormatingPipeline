# .NET Formatting Pipeline

Ce projet démontre la création d'une application "Hello World" en C# .NET avec une pipeline de vérification du formatage du code.

## 🚀 Application Hello World

L'application est située dans le dossier `HelloWorld/` et affiche un message de bienvenue en français et en anglais.

### Exécution

```bash
# Exécuter l'application
cd HelloWorld/
dotnet run

# Exécuter avec des arguments
dotnet run -- arg1 arg2
```

### Build

```bash
# Restaurer les dépendances
dotnet restore HelloWorld/

# Compiler l'application
dotnet build HelloWorld/
```

## 🔧 Pipeline de Formatage

Ce projet inclut une pipeline GitHub Actions qui vérifie automatiquement le formatage du code sur chaque push et pull request.

### Vérification locale du formatage

```bash
# Vérifier le formatage sans modifications
dotnet format HelloWorld/ --verify-no-changes

# Appliquer le formatage automatiquement
dotnet format HelloWorld/
```

### Configuration

- **`.editorconfig`** : Définit les règles de formatage et de style de code
- **`.github/workflows/format-check.yml`** : Pipeline GitHub Actions pour la vérification

### Fonctionnalités de la pipeline

1. ✅ **Build automatique** : Compilation de l'application
2. ✅ **Tests** : Exécution des tests (si présents)
3. ✅ **Vérification du formatage** : Validation que le code respecte les standards
4. ✅ **Test fonctionnel** : Exécution de l'application pour vérifier son bon fonctionnement

## 📋 Standards de Code

Le projet utilise les standards de formatage .NET avec quelques personnalisations :

- Indentation : 4 espaces pour C#
- Fin de ligne : CRLF
- Namespaces : Style file-scoped
- Accolades : Nouvelle ligne pour toutes les constructions

## 🛠️ Technologies

- **.NET 8.0** : Framework principal
- **GitHub Actions** : CI/CD pour la vérification du formatage
- **EditorConfig** : Configuration standardisée pour les éditeurs