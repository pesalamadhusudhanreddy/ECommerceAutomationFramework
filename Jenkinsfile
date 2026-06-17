pipeline {

    agent any

    stages {

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

stage('Publish Extent Report') {
    steps {
        publishHTML([
            reportDir: 'Reports',
            reportFiles: 'index.html',
            reportName: 'Extent Report',
            allowMissing: false,
            alwaysLinkToLastBuild: true
        ])
    }
}

    }
}