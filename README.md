# DiiageCustomerApp


[![Quality gate](https://sonarcloud.io/api/project_badges/quality_gate?project=ttmartinks_tp2_devops)](https://sonarcloud.io/summary/new_code?id=ttmartinks_tp2_devops)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=ttmartinks_tp2_devops&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=ttmartinks_tp2_devops)

## Présentation

DiiageCustomerApp est une application de gestion d'informations étudiantes développée dans le cadre d'un projet pédagogique.  
Elle s'appuie sur une architecture multi-couches (Business, Domain, Persistence, WebUi) et met en œuvre des pratiques DevOps modernes (CI/CD, analyse statique, etc.).

## Stratégie Git

La stratégie Git adoptée pour ce projet est la suivante :

- **Branche principale :**  
  La branche `main` contient le code stable et validé, prêt à être déployé en production.

- **Branches de fonctionnalités :**  
  Chaque nouvelle fonctionnalité ou correction de bug est développée dans une branche dédiée, nommée `feature/nom-fonctionnalite` ou `fix/nom-correction`.

- **Pull Requests :**  
  Toute modification doit faire l'objet d'une Pull Request vers `main`.  
  Les revues de code sont obligatoires avant fusion.

- **Intégration continue :**  
  Chaque push ou PR déclenche automatiquement le pipeline CI et l'analyse SonarCloud.

- **Tags :**  
  Les versions majeures sont taguées pour faciliter le suivi des releases.

## Lancer le projet

Voir les instructions détaillées dans le fichier [README.md](README.md).

---