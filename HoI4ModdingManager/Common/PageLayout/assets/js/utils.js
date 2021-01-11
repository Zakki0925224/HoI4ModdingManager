function RGBtoHEX (r, g, b)
{
    // using jquery
    const rHex = r.toString(16).replace(/(^[0-9a-f]{1}$)/, '0$1');
    const gHex = g.toString(16).replace(/(^[0-9a-f]{1}$)/, '0$1');
    const bHex = b.toString(16).replace(/(^[0-9a-f]{1}$)/, '0$1');

    return "#" + rHex + gHex + bHex;
}