"# Git commands " 

📌 GIT & GITHUB – COMPLETE PROPER NOTES
1️⃣ What is Git?
Git is a distributed version control system used to:
Track code changes
Work in a team
Manage project history
Rollback to old versions
2️⃣ Git Architecture
Copy code

Working Directory → Staging Area → Local Repository → Remote Repository
Area
Meaning
Working directory
Where you edit files
Staging area
Files ready to commit
Local repo
Your system repository
Remote repo
GitHub repository
3️⃣ Basic Git Setup
Install Git
Copy code

sudo apt install git
Check version
Copy code

git --version
Configure username & email
Copy code

git config --global user.name "Your Name"
git config --global user.email "your@gmail.com"
Check config
Copy code

git config --list
4️⃣ Create Repository
Create folder
Copy code

mkdir project
cd project
Initialize git
Copy code

git init
Check hidden files
Copy code

ls -a
5️⃣ File Operations
Create file
Copy code

touch index.html
Open file
Copy code

nano index.html
Check file status
Copy code

git status
6️⃣ Staging & Commit
Add single file
Copy code

git add index.html
Add all files
Copy code

git add .
Commit
Copy code

git commit -m "Initial commit"
7️⃣ View History
Copy code

git log
One line log
Copy code

git log --oneline
8️⃣ Branching
Show branches
Copy code

git branch
Create branch
Copy code

git branch dev
Switch branch
Copy code

git checkout dev
Create & switch
Copy code

git checkout -b feature
Delete branch
Copy code

git branch -d dev
9️⃣ Merge Branch
Copy code

git checkout main
git merge dev
🔟 Remote Repository (GitHub)
Add remote
Copy code

git remote add origin <repo-url>
Check remote
Copy code

git remote -v
Push code
Copy code

git push -u origin main
Pull code
Copy code

git pull origin main
Clone repo
Copy code

git clone <repo-url>
1️⃣1️⃣ Stash (Temporary Save)
Save changes
Copy code

git stash
Show stash
Copy code

git stash list
Apply stash
Copy code

git stash apply
Remove stash
Copy code

git stash drop
1️⃣2️⃣ Reset (⚠ Dangerous)
Type
Command
Use
Soft
git reset --soft HEAD~1
Keep changes
Mixed
git reset HEAD~1
Unstage
Hard
git reset --hard HEAD~1
Delete all
1️⃣3️⃣ Revert (Safe)
Copy code

git revert <commit-id>
✔ Creates new commit
✔ Safe for production
Why Revert over Reset in Production?
Reset
Revert
Changes history
Keeps history
Dangerous
Safe
Deletes commits
Creates new commit
Not for team
Best for team
1️⃣4️⃣ Undo Changes
Undo unstaged file
Copy code

git checkout -- file.txt
Unstage file
Copy code

git reset file.txt
1️⃣5️⃣ Cherry Pick
Copy code

git cherry-pick <commit-id>
✔ Copy commit from another branch
1️⃣6️⃣ Tags
Create tag
Copy code

git tag v1.0
Show tags
Copy code

git tag
1️⃣7️⃣ Git Ignore
Create file:
Copy code

.gitignore
Add:
Copy code

node_modules
.env
1️⃣8️⃣ HEAD
HEAD → Points to current commit
1️⃣9️⃣ Check Differences
Copy code

git diff
2️⃣0️⃣ Pull Request (PR)
Pull Request means:
Request to merge your code into main branch (on GitHub)
2️⃣1️⃣ DevOps Tool Chain
Copy code

Git → Jenkins → Maven → Docker → Kubernetes → Prometheus → Grafana
2️⃣2️⃣ Common Errors
Error
Fix
Nothing to commit
Working tree clean
Push rejected
Do git pull
Merge conflict
Fix manually
