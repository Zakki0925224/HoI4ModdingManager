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
}

function SetStatus(thisCountryData)
{
    document.getElementById("country_name").textContent = thisCountryData.Country_name;
    document.getElementById("political_power_count").textContent = thisCountryData.Initial_political_power;
    document.getElementById("stability_count").textContent = thisCountryData.Initial_stability + "%";
    document.getElementById("war_coop_count").textContent = thisCountryData.Initial_war_coop + "%";
    document.getElementById("transport_count").textContent = thisCountryData.Initial_transport;
    document.getElementById("ideology_text").textContent = thisCountryData.Initial_ideology;
}

function SetPartySupportGraph(thisCountryData, ideologyData)
{
    // neutrality party support count
    const nPartySupportCount = thisCountryData.Party_support_neutrality;
    // democratic party support count
    const dPartySupportCount = thisCountryData.Party_support_democratic;
    // fascism party support count
    const fPartySupportCount = thisCountryData.Party_support_fascism;
    // communism party support count
    const cPartySupportCount = thisCountryData.Party_support_communism;

    // neutrality party name (long)
    const nPartyName = thisCountryData.Party_name_neutrality_long;
    // democratic party name (long)
    const dPartyName = thisCountryData.Party_name_democratic_long;
    // fascism party name (long)
    const fPartyName = thisCountryData.Party_name_fascism_long;
    // communism party name (long)
    const cPartyName = thisCountryData.Party_name_communism_long;

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