function SetCountryData(country_name,
                        initial_political_power,
                        initial_stability,
                        initial_war_coop,
                        initial_transport,
                        initial_ideology,
                        party_support_neutrality,
                        party_support_democratic,
                        party_support_fascism,
                        party_support_communism,
                        darkmode)
{
    document.getElementById("country_name").textContent = country_name;
    document.getElementById("political_power_count").textContent = initial_political_power;
    document.getElementById("stability_count").textContent = initial_stability + "%";
    document.getElementById("war_coop_count").textContent = initial_war_coop + "%";
    document.getElementById("transport_count").textContent = initial_transport;
    document.getElementById("ideology_text").textContent = initial_ideology;

    // demo
    SetPartySupportGraph(party_support_neutrality,
                         party_support_democratic,
                         party_support_fascism,
                         party_support_communism);
}

function SetPartySupportGraph(count_n, count_d, count_f, count_c)
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
                    data: [count_n, count_d, count_f, count_c]
                }]
            }
        }
    );
}