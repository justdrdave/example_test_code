# Capital on Tap Coding Challange Part 1

## Installation

1. Make sure [Node.js](https://nodejs.org/) is installed
2. Navigate to the root of the repo
3. Use the `npm install` command

## Running tests

To run tests via a terminal ```sh $ npm run xxx``` where xxx is replaced by one of the values from the list below.

- **test** runs in default browser (chrome)
- **test-chrome** runs in chrome
- **test-ie** runs in ie
- **test-edge** runs in edge
- **test-firefox** runs in firefox
- **test-opera** runs in opera
- **test-safari** runs in safari
- **test-chrome-headless** runs in headless chrome
- **test-firefox-headless** runs in headless firefox

Tests tagged with **@Pending** are skipped as they are considered to be incomplete

In addition the following can be run

- **report** generates a pretty html report following a test run
- **xml** generates a xml report following a test run, this is used by Azure DevOps to read in the test results in the CICD system
- **lint** makes sure code matches defined standards

## CI

Included are three pipeline files for Azure DevOps:
The first azure-pipelines.yml runs in headless Chrome on a Microsoft supplied Linux Build Agent for the fastest possible feedback.
The other two files run the tests on Microsoft supplied Windows and Mac OS build agents for every availible browser on those agents.
All test results are written out to the Azure DevOps Test Runs component to take advantage of in built test reporting and to allow analytics to be collected on pass/fail rates of individual tests.

Note: Mac OS pipeline will fail due to latest security features requiring GUI access to enable 'screen recording' to be enabled. Known issue with no current work arround.