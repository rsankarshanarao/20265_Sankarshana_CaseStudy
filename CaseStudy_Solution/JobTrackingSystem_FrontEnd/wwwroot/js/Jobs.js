const uri = 'https://localhost:44367/api/Jobs';
let jobs = [];

function getJobs() {
    /*fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));*/
    $.ajax({
        type: "GET",
        url: uri,
        success: function (response) {
            console.log(response)
            _displayJobs(response)
        },
        failure: function (response) {
            alert(response.d);
        }
    });
};

function _displayCount(jobCount) {
    const name = (jobCount === 1) ? 'Job' : 'Jobs';

    document.getElementById('counter').innerText = `${jobCount} ${name}`;
};

function closeInput() {
    document.getElementById('EditJob').style.display = 'none';
    document.getElementById('AddJob').style.display = 'none';
}

function _displayJobs(data) {
    const tBody = document.getElementById('jobs');
    tBody.innerHTML = '';

    _displayCount(data.length);

    const button = document.createElement('button');

    data.forEach(job => {
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${job.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteJobr(${job.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(document.createTextNode(job.id));

        let td2 = tr.insertCell(1);
        td2.appendChild(document.createTextNode(job.creator));

        let td3 = tr.insertCell(2);
        td3.appendChild(document.createTextNode(job.owner));

        let td4 = tr.insertCell(3);
        td4.appendChild(document.createTextNode(job.name));

        let td5 = tr.insertCell(4);
        td5.appendChild(document.createTextNode(job.description));

        let td6 = tr.insertCell(5);
        td6.appendChild(document.createTextNode(job.status));

        let td7 = tr.insertCell(6);
        td7.appendChild(document.createTextNode(job.priority));

        let td8 = tr.insertCell(7);
        td8.appendChild(document.createTextNode(job.notes));

        let td9 = tr.insertCell(8);
        td9.appendChild(document.createTextNode(job.bookmark));

        let td10 = tr.insertCell(9);
        td10.appendChild(document.createTextNode(createdOn));

        let td11 = tr.insertCell(10);
        td11.appendChild(document.createTextNode(statusChangedOn));

        let td12 = tr.insertCell(11);
        td12.appendChild(editButton);
        td12.appendChild(deleteButton);

    });

    jobs = data;
}