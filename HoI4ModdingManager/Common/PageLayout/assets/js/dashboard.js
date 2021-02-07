function GetCountryData(thisCountryData,countryData,projectData,ideologyData)
{
    // debug log
    console.log("This country data");
    console.log(thisCountryData);
    console.log("Country data(all)");
    console.log(countryData);
    console.log("Project data");
    console.log(projectData);
    console.log("Ideology data");
    console.log(ideologyData);

    SetStatus(thisCountryData);
    SetPartySupportGraph(thisCountryData, ideologyData);
    AddPartyCard(thisCountryData, ideologyData);
}

function SetStatus(thisCountryData)
{
    document.getElementById("country_name").textContent = thisCountryData.Name;
    document.getElementById("political_power_count").textContent = thisCountryData.PoliticalPower;
    document.getElementById("stability_count").textContent = thisCountryData.Stability + "%";
    document.getElementById("war_coop_count").textContent = thisCountryData.WarSupport + "%";
    document.getElementById("transport_count").textContent = thisCountryData.Convoys;
    document.getElementById("ideology_text").textContent = thisCountryData.RulingPartyIdeology;
}

function SetPartySupportGraph(thisCountryData, ideologyData)
{
    // neutrality party support count
    const nPartySupportCount = thisCountryData.PartySupports[0];
    // democratic party support count
    const dPartySupportCount = thisCountryData.PartySupports[1];
    // fascism party support count
    const fPartySupportCount = thisCountryData.PartySupports[2];
    // communism party support count
    const cPartySupportCount = thisCountryData.PartySupports[3];

    // neutrality party name (long)
    const nPartyName = thisCountryData.PartyNames[1];
    // democratic party name (long)
    const dPartyName = thisCountryData.PartyNames[3];
    // fascism party name (long)
    const fPartyName = thisCountryData.PartyNames[5];
    // communism party name (long)
    const cPartyName = thisCountryData.PartyNames[7];

    var ctx = document.getElementById("party_support_graph");
    var party_support_graph = new Chart
    (
        ctx,
        {
            type: "doughnut",
            data:
            {
                labels: [nPartyName, dPartyName, fPartyName, cPartyName],
                datasets:
                [{
                    backgroundColor: ["#7c7c7c", "#0000ff", "#964b00", "#ff0000"],
                    data: [nPartySupportCount, dPartySupportCount, fPartySupportCount, cPartySupportCount]
                }]
            },
            options:
            {
                tooltips:
                {
                    callbacks:
                    {
                        label: function (tooltipItem, data)
                        {
                            return data.labels[tooltipItem.index] + ": " + data.datasets[0].data[tooltipItem.index] + " %";
                        }
                    }
                }
            }
        }
    );
}

function AddPartyCard(thisCountryData, ideologyData)
{
    const cardsCount = Object.keys(ideologyData).length;
    var container = document.getElementById("party_cards_container");

    for (let i = 0; i < cardsCount; i++)
    {
        const ideologyName = ideologyData[i].Name;
        let partyName;
        let partySupport;
        const partyLeaderName = "Donald Trump"; // temporary

        if (ideologyName == "neutrality")
        {
            partyName = thisCountryData.PartyNames[1];
            partySupport = thisCountryData.PartySupports[0];
        }

        else if (ideologyName == "democratic")
        {
            partyName = thisCountryData.PartyNames[3];
            partySupport = thisCountryData.PartySupports[1];
        }

        else if (ideologyName == "fascism")
        {
            partyName = thisCountryData.PPartyNames[5];
            partySupport = thisCountryData.PartySupports[2];
        }

        else if (ideologyName == "communism")
        {
            partyName = thisCountryData.PartyNames[7];
            partySupport = thisCountryData.PartySupports[3];
        }
        else
        {
            partyName = "";
            partySupport = "";
        }

        var card = document.createElement("div");
        card.setAttribute("class", "card");
        card.setAttribute("style", "width: 25rem;");

        var cardBody = document.createElement("div");
        cardBody.setAttribute("class", "card-body");
        card.appendChild(cardBody);

        var cardTitle = document.createElement("h4");
        cardTitle.setAttribute("class", "card-title");
        cardTitle.appendChild(document.createTextNode(partyName));
        cardBody.appendChild(cardTitle);

        var cardSubTitle = document.createElement("h6");
        cardSubTitle.setAttribute("class", "card-subtitle mb-2 text-secondary");
        cardSubTitle.appendChild(document.createTextNode("opposition party"));
        cardBody.appendChild(cardSubTitle);

        var table = document.createElement("table");
        table.setAttribute("class", "table");
        cardBody.appendChild(table);

        var tableBody = document.createElement("tbody");
        table.appendChild(tableBody);

        var tr1 = document.createElement("tr");
        tableBody.appendChild(tr1);

        var leaderSection = document.createElement("th");
        leaderSection.setAttribute("scope", "row");
        leaderSection.appendChild(document.createTextNode("Leader"));
        tr1.appendChild(leaderSection);

        var leaderValue = document.createElement("td");
        leaderValue.appendChild(document.createTextNode(partyLeaderName));
        tr1.appendChild(leaderValue);

        var tr2 = document.createElement("tr");
        tableBody.appendChild(tr2);

        var ideologySection = document.createElement("th");
        ideologySection.setAttribute("scope", "row");
        ideologySection.appendChild(document.createTextNode("Ideology"));
        tr2.appendChild(ideologySection);

        var ideologyValue = document.createElement("td");
        ideologyValue.appendChild(document.createTextNode(ideologyName));
        tr2.appendChild(ideologyValue);

        var tr3 = document.createElement("tr");
        tableBody.appendChild(tr3);

        var supportSection = document.createElement("th");
        supportSection.setAttribute("scope", "row");
        supportSection.appendChild(document.createTextNode("Party approval rating"));
        tr3.appendChild(supportSection);

        var supportValue = document.createElement("td");
        supportValue.appendChild(document.createTextNode(partySupport + "%"));
        tr3.appendChild(supportValue);

        container.appendChild(card);
    }
}