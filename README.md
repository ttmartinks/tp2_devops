# DiiageCustomerApp – CI/CD avec GitHub Actions, Runner Local & SonarCloud

![CI](https://github.com/TON-UTILISATEUR/TON-DEPOT/actions/workflows/ci.yml/badge.svg)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=TON-ORGANISATION_TON-PROJET&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TON-ORGANISATION_TON-PROJET)

---

## Prérequis

- **Ordinateur portable** avec accès à Internet
- **Navigateur web** (Chrome, Firefox, Edge, etc.)
- **Compte GitHub** ([Créer un compte](https://github.com/join))
- **Compte SonarCloud** ([Créer un compte](https://sonarcloud.io/))

---

## Stratégie Git

- **Aucun push direct** sur `main` ou `develop` n’est autorisé.
- Toute modification passe **exclusivement par une pull request** (PR) :
  - Créer une branche à partir de `develop` :  
    `git checkout develop && git pull origin develop && git checkout -b feature/ma-fonctionnalite`
  - Développer, committer, puis pousser la branche :  
    `git push -u origin feature/ma-fonctionnalite`
  - Ouvrir une PR vers `develop` sur GitHub.
  - Attendre la revue, la validation CI et la Quality Gate SonarCloud verte avant de fusionner.
- Les branches `main` et `develop` sont protégées par des règles GitHub (voir section dédiée).

---

## Pipeline CI/CD

Le pipeline CI/CD est basé sur **GitHub Actions** et s’exécute sur un **runner local**.

### Déclencheurs

- Sur `push` et `pull_request` vers la branche `develop`.

### Étapes principales

1. **dotnet restore**  
2. **dotnet build**  
3. **dotnet test**  
4. **Analyse SonarCloud** (avec token sécurisé)

---

## Configuration du runner local

1. Aller dans **Settings > Actions > Runners** sur GitHub.
2. Cliquer sur **New self-hosted runner** et suivre les instructions pour ton OS.
3. Installer le SDK .NET ([lien](https://dotnet.microsoft.com/download)).
4. Lancer le runner avec :  
   - Windows : `.\run.cmd`
   - Linux/Mac : `./run.sh`
5. Laisser la fenêtre ouverte pendant l’exécution du pipeline.

---

## Protection des branches

- **Interdiction des push directs** sur `main` et `develop`.
- **Pull request obligatoire** avec :
  - CI verte (build, tests, SonarCloud Quality Gate)
  - Au moins une revue approuvée
- Configuration visible dans :  
  `Settings > Branches > Branch protection rules`

---

## Badges

- **SonarCloud** : [![SonarQube Cloud](https://sonarcloud.io/images/project_badges/sonarcloud-light.svg)](https://sonarcloud.io/summary/new_code?id=ttmartinks_tp2_devops) [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=ttmartinks_tp2_devops&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=ttmartinks_tp2_devops)

---

## Livrables attendus

- Pipeline CI opérationnel exécuté sur **runner local**
- README contenant :
    - Badge du pipeline
    - Badge SonarCloud
    - Description de la stratégie Git
- Screenshot du runner local actif
- Screenshot du pipeline exécuté localement
- Screenshot de la Quality Gate
- Screenshot des protections de branches
- PR de `feature/ci-pipeline` vers `develop` validée

---

## Screenshots

Ajoutez ici vos captures d’écran :

- Runner local actif
- Pipeline exécuté localement (GitHub Actions avec tag `self-hosted`)
- Quality Gate SonarCloud verte
- Protections de branches GitHub
- PR validée

---

## Liens utiles

- [Documentation GitHub Actions](https://docs.github.com/en/actions)
- [Documentation SonarCloud](https://docs.sonarcloud.io/)
- [Documentation .NET](https://learn.microsoft.com/dotnet/)

---
