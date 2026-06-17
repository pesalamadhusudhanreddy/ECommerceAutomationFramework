pipeline {

    agent any

    stages {

        stage('Checkout') {
            steps {
                git 'https://github.com/pesalamadhusudhanreddy/ECommerceAutomationFramework.git'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build'
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }

    }
}