# Code Coverage Demo

[![codecov](https://codecov.io/gh/pradeep-singh-talabat/CodeCoverageDemo/branch/master/graph/badge.svg)](https://codecov.io/gh/pradeep-singh-talabat/CodeCoverageDemo)

A full fledged CI/CD and code coverage demo using CircleCI and CodeCov in combination with GitHub Actions.

## Repository Structure

The structure of the repository follows the most common convention prevalent today. The repository is organized in the following sections.
```
root-----
        |
        ----src
        |
        ----test
        |
        ----tools
        |
        ----.circleci
        |
        ----.github
```

## src

This directory contains the main source code from the application, library or service.

## test

This directory contains the source code for the tests.

## tools

This directory contains the tools and scripts used in development, testing and deployment scenarios.

## .circleci

This directory contains the circle-ci build configuration file with jobs and work flows.

## .github

This folder contains the Github Metadata and Workflow files which are used in the automated CI/CD. For a detailed description of each item, please refer to the following sections.

### pull_request_template.md

This is the pull request markdown template file which is used for to automatically put a nice template on your pull request whenever to create a new pull request. ~~You can customize or extend this in your repositories when to you create a new repository using this template. Please make sure you remove this part (crossed out text) from destination repository file.~~

### workflows directory

This directory contains the pre-configured workflows (Github actions) that help in triggering a QA build whenever someone adds the approved label on a PR. You can disable any action that you don't need by going to the **Actions** tab on the destination repository. Here is a brief description of each action.

#### Preconfigured actions

To use these actions you need to define the following secrets in the repository. We have already defined the values for **CIRCLE_CI_QA_JOB** and **CIRCLE_CI_RELEASE_JOB** secrets in this template repository (based on the sample sample circleci [config.yml](../.circleci/config.yml)) file. You can change them if you have different names in your final config.yml file.
* CIRCLE_CI_TOKEN: The circle CI token for circle-ci webhooks
* CIRCLE_CI_QA_JOB: The name of the circle-ci QA job from your [config.yml](../.circleci/config.yml) file (by default we use ```qa```).
* CIRCLE_CI_RELEASE_JOB: The name of the circle-ci production release job defined in your [config.yml](../.circleci/config.yml) file (by default we use ```release```).

The following actions are pre-configured in your repository. 
1. Publish a pre-release packages(only .NET and .NET Core projects) for pull requests.
2. Auto deploy to QA (by triggerring a circle CI build) whenever some adds ```approved``` tag on a PR. You need to create appropriate circle CI jobs in the circle CI [```.circleci```](../.circleci/README.md) folder.
3. Auto deploy to production when you create a tag. For more information about Tag please refer to [Github Documentation](https://developer.github.com/v3/git/tags/).

ToDo: Fix the timeout on CodeCov
