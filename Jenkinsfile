pipeline {
  agent any
  stages {
    stage('Hello world') {
      parallel {
        stage('Hello world') {
          steps {
            bat(script: 'echo "Hello"', returnStatus: true)
            echo 'Hello World'
          }
        }
        stage('Hello') {
          steps {
            build(job: 'artifactory pipeline', propagate: true)
          }
        }
      }
    }
  }
}