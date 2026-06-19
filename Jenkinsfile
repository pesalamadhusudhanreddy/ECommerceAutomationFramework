pipeline {

agent any

stages {

stage('Clean') {
    steps {
        deleteDir()
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

stage('Publish Extent Report') {
    steps {

        bat 'dir ECommerce.Tests\\bin\\Debug\\net8.0\\Reports'

        publishHTML([
            allowMissing: false,
            keepAll: true,
            alwaysLinkToLastBuild: true,
            reportDir: 'ECommerce.Tests/bin/Debug/net8.0/Reports',
            reportFiles: 'ExtentReport.html',
            reportName: 'Extent Report'
        ])
    }
}

}

}