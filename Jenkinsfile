pipeline {

    agent any

    stages {

        stage('Clean') {
            steps {
                cleanWs()
            }
        }

        stage('Checkout') {
            steps {
                git branch: 'main',
                    url: 'https://github.com/pesalamadhusudhanreddy/ECommerceAutomationFramework.git'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build ECommerceAutomationFramework.sln'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test ECommerceAutomationFramework.sln'
            }
        }

        stage('Publish Extent Report') {
            steps {

                bat 'dir ECommerce.Tests\\bin\\Debug\\net8.0\\Reports'

                publishHTML([
                    allowMissing: false,
                    alwaysLinkToLastBuild: true,
                    keepAll: true,
                    reportDir: 'ECommerce.Tests/bin/Debug/net8.0/Reports',
                    reportFiles: 'ExtentReport.html',
                    reportName: 'Extent Report'
                ])
            }
        }
    }
}