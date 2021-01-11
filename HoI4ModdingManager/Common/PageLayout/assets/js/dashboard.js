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
    var ctx = document.getElementById("party_support_graph");
    var party_support_graph = new Chart
    (
        ctx,
        {
            type: "doughnut",
            data:
            {
                labels: ["Neutrality", "Democratic", "Fascism", "Communism"],
                datasets:
                [{
                    backgroundColor: ["#7c7c7c", "#0000ff", "#964b00", "#ff0000"],
                    data: [thisCountryData.Party_support_neutrality, thisCountryData.Party_support_democratic, thisCountryData.Party_support_fascism, thisCountryData.Party_support_communism]
                }]
            }
        }
    );
}