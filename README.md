# CoreServiceForDocker

TEST CHANGES TEST CHANGES TEST CHANGES TEST CHANGES TEST CHANGES 

I created a .Net Core solution and used docker to create an image and pushed it to my docker repo. 
Only thing I added to this .Net Core solution is the docker file. 

My notes is below to use docker.



# Docker Presentation
 

 
# Docker Intro
What is Docker?
Docker is a containerisation technology and application platform that lets us package and deploy an application or service as an isolated unit containing all of its dependencies. In over simplified terms it can be thought of as a very lightweight, self contained virtual machine.
 
Docker containers run on top of a shared OS kernel, but in an isolated way. They are very lightweight which is where they offer an advantage over traditional VMs. 
 
Key Concepts
 
Image: An image is a lightweight, stand-alone, executable package that includes everything needed to run a piece of software, including the code, a runtime, libraries, environment variables, and config files.
 
Container: A container is a runtime instance of an image—what the image becomes in memory when actually executed. It runs completely isolated from the host environment by default, only accessing host files and ports if configured to do so.
 
Containers Vs VMs

Virtual machines run guest operating systems—note the OS layer in each box. This is resource intensive, and the resulting disk image and application state is an entanglement of OS settings, system-installed dependencies, OS security patches, and other easy-to-lose, hard-to-replicate ephemera.
 
Containers can share a single kernel, and the only information that needs to be in a container image is the executable and its package dependencies, which never need to be installed on the host system. These processes run like native processes, and you can manage them individually by running commands like docker ps—just like you would run ps on Linux to see active processes. Finally, because they contain all their dependencies, there is no configuration entanglement; a containerized app “runs anywhere.”
 
 
# Docker Installation
 
Docker for Windows 
Win Server 2016 and Windows 10 Pro can now have native windows containers.
 
Docker Toolbox
For other Windows 10 versions we can use docker toolbox.
 
 
 
 
# Tour of Docker with some commands
 
Docker Client  And Docker Daemon
 
docker --version
Shows the docker engine version
 
docker version
Shows more detail of Client and Server
 
docker info
Shows all the details and state of the docker 
 
docker ps
Lists all the containers that are currently running
 
docker ps -a
Lists all the containers that are running and stopped
 
docker images
Lists all the docker images
 
docker stop
Stops the running container. Need to use the Container Id
 
docker rm
Removes the docker container
 
docker rmi
Removes the docker images
 
docker build
Builds a new images based on the dockerfile
 
docker run
Runs the new instance of a container
 
docker login
Logs into the hub.docker.com
 
docker tag
Tags a docker container with a name
 
docker push
Push the docker image to the hub.docker.com repository
 
docker pull
Pull the image from the hub.docker.com repository
 
Show DOcker Repository
 
Running a docker image (hello-world)
docker run hello-world
 
# Creating docker image of the .Net application that we created 
Dockerfile: We can define a container with the dockerfile. Dockerfile will define what goes on in the environment inside your container. Access to resources like networking interfaces and disk drives is virtualized inside this environment, which is isolated from the rest of your system, so you have to map ports to the outside world, and be specific about what files you want to “copy in” to that environment. However, after doing that, you can expect that the build of your app defined in this Dockerfile will behave exactly the same wherever it runs.
 
Examples
FROM microsoft/dotnet:latest
COPY . /app
WORKDIR /app
 
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
 
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
 
ENTRYPOINT ["dotnet", "run"]
 
 
 
# Uploading the image we created to the Repository
 
# Next Steps
Services
Swarms
Deploying to Azure or AWS
Container Management
	Swarm Vs Kubernetes
Working with Repositories
Deployment Tools
 
 
