pipeline {
    agent any

    
    stages{    
     stage('Organise Files')
        {                         
         steps{  
                script
                {                        
                  import shutil
import os
    
source_dir = 'home\worskspace'
target_dir = '\\var\www\html'
    
file_names = os.listdir(source_dir)
    
for file_name in file_names:
    shutil.move(os.path.join(source_dir, file_name), target_dir)            
                }                                
              }                           
        } 
    

        stage('Create') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Build') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Test') {
            steps {
                echo 'Hello World'
            }
        }
        stage('Release') {
            steps {
                echo 'Hello World'
            }
        }
    }
}
