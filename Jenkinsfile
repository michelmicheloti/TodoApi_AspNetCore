pipeline {
  agent any
  stages {
    stage('error') {
      steps {
        sh 'apt install snapd'
        sh 'snap install --classic heroku'
      }
    }

  }
}