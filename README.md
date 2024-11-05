<h1>
  <img src="./READMEmedia/weatherstations_logo.png" alt="Project Logo" width="100" height="100" style="vertical-align: middle;">
  Meten is Weten: Climate Measurement Station API
</h1>

# Introduction

Climate change is a pressing issue that demands a better understanding of its real impact on our environment. To help gather valuable data, this project aims to create a network of measurement stations that can be deployed globally to continuously monitor environmental and weather conditions.

Each station is designed to be energy self-sufficient, using solar panels and batteries, and equipped with sensors tailored to the needs of the location. These sensors may vary per station, monitoring parameters such as wind speed, rainfall, CO2 levels, fine particles, volatile organic compounds (VOCs), and more.

Data collected from each station is transmitted to a centralized platform, which stores the information and makes it accessible through a web interface. Users can explore the stations on a detailed map, zooming in to see current sensor readings and historical data. New stations are automatically added to the system whdbazjhdzahgen activated.

This repository contains the API that powers the interaction between the measurement stations and the central database, enabling data collection, retrieval, and visualization.

# Running the project

---

# Frontend requesting live data flow example

![requestingLiveData.png](./READMEmedia/requestingLiveData.png)

# Database structure
## "stations" table
| column | PK | FK | type | nullable | auto increment |
| :----: | :----: | :----: | :----: | :----: | :----: |
| id | yes | no | string | no | no |
| battery_level | no | no | double | yes | no |
| latitude | no | no | double | no | no |
| longitude | no | no | double | no | no |
| name | no | no | string | yes | no |
| description | no | no | string | yes | no |

## "sensors" table
| column | PK | FK | type | nullable | auto increment |
| :----: | :----: | :----: | :----: | :----: | :----: |
| id | yes | no | int | no | yes |
| type | no | no | string | no | no |
| unit | no | no | string | no | no |

## "measurements" table
| column | PK | FK | type | nullable | auto increment |
| :----: | :----: | :----: | :----: | :----: | :----: |
| timestamp | yes | no | datetime | no | no |
| station_id | yes | stations(id) | string | no | no |
| sensor_id | yes | sensors(id) | int | no | no |
| sensor_value | no | no | string | no | no |
## "station_sensors" table
| column | PK | FK | type | nullable | auto increment |
| :----: | :----: | :----: | :----: | :----: | :----: |
| station_id | yes | stations(id) | string | no | no |
| sensor_id | yes | sensors(id) | int | no | no |

# API endpoints
## basic API response structure
**succes response:**
```json
{
  "status": "success",
  "message": "Station location updated successfully.",
  "data": {
    "staionId": "WSTATION-XXXXXXXX",
    "location": {
      "latitude": "XX.XXXXXX",
      "longitude": "XX.XXXXXX"
    }
  }
}
```
**error response:**
```json
{
  "status": "error",
  "message": "Invalid station ID.",
  "errors": [
    {
      "field": "stationId",
      "issue": "The station ID provided does not exist."
    }
  ]
}
```
**pagination response:**
```json
{
  "status": "success",
  "message": "Stations retrieved successfully.",
  "data": [
    {
	    "staionId": "WSTATION-XXXXXXXX",
      "location": {
        "latitude": "XX.XXXXXX",
        "longitude": "XX.XXXXXX"
      },
      "name": null,
      "description": null
    },
    {
	    "staionId": "WSTATION-XXXXXXXX",
      "location": {
        "latitude": "XX.XXXXXX",
        "longitude": "XX.XXXXXX"
      },
      "name": null,
      "description": null
    },
    ...
  ],
  "meta": {
    "total": 100,
    "page": 1,
    "perPage": 10,
    "totalPages": 10
  }
}
```

[Determining the size of a page for pagination in an API that sends JSON data.](./READMEmedia/pagination_guide.md)

## GET baseurl/api/v1/stations
**success response:**
```json
{
  "status": "success",
  "message": "Stations retrieved successfully.",
  "data": [
    {
      "staionId": "WSTATION-XXXXXXXX",
      "location": {
        "latitude": "XX.XXXXXX",
        "longitude": "XX.XXXXXX"
      },
      "name": null,
      "description": null
    },
    {
      "staionId": "WSTATION-XXXXXXXX",
      "location": {
        "latitude": "XX.XXXXXX",
        "longitude": "XX.XXXXXX"
      },
      "name": null,
      "description": null
    },
    ...
  ],
  "meta": {
    "total": 100,
    "page": 1,
    "perPage": 10,
    "totalPages": 10
  }
}
```
## GET baseurl/api/v1/stations/{stationId}
**success response:**
```json
{
  "status": "success",
  "message": "Station retrieved successfully.",
  "data": {  
    "staionId": "WSTATION-XXXXXXXX",
    "location": {
      "latitude": "XX.XXXXXX",
      "longitude": "XX.XXXXXX"
    },
    "name": null,
    "description": null,
    "sensors": [
      {
        "id": X,
        "type": "temperature",
        "unit": "celsius"
      },
      ...
    ]
  }
}
```
## GET baseurl/api/v1/stations/{stationId}/location
**success response:**
```json
{
  "status": "success",
  "message": "Station location retrieved successfully.",
  "data": {  
    "staionId": "WSTATION-XXXXXXXX",
    "location": {
      "latitude": "XX.XXXXXX",
      "longitude": "XX.XXXXXX"
    }
  }
}
```
## GET baseurl/api/v1/stations/{stationId}/sensors
**success response:**
```json
{
  "status": "success",
  "message": "Station sensors retrieved successfully.",
  "data": {
    "staionId": "WSTATION-XXXXXXXX",
    "sensors": [
      {
        "id": X,
        "type": "temperature",
        "unit": "celsius"
      },
      ...
    ]
  }
}
```
## GET baseurl/api/v1/stations/{stationId}/measurements
**query parameters:**
| parameter | required | default | limits | extra |
| :----: | :----: | :----: | :----: | :----: |
| from | no | 1 month ago | can't be in the future | utc;<br>format: YYYY-MM-DDTHH:MM:SSZ |
| to | no | from + 1 month | must be greater then from;<br>can't be in the future | utc;<br>format: YYYY-MM-DDTHH:MM:SSZ |
| sensorId | no | null |  | multiple allowed |
| page | no | 1 |  |  |
| perpage | no | 100 |  |  |

**success response:**
```json
{
  "status": "success",
  "message": "Station measurements retrieved successfully.",
  "data": [
    {
      "sensorId": X,
      "sensorType": "temperature",
      "sensorUnit": "celsius",
      "sensorValues": [
        {
          "timestamp": "YYYY-MM-DDTHH:MM:SSZ",
          "value": ""
        },
        {
          "timestamp": "YYYY-MM-DDTHH:MM:SSZ",
          "value": ""
        },
        ...
      ]
    },
    ...
  ],
  "meta": {
    "total": 100,
    "page": 1,
    "perPage": 10,
    "totalPages": 10
  }
}
```
## GET baseurl/api/v1/sensors
**success response:**
```json
{
  "status": "success",
  "message": "Sensors retrieved successfully.",
  "data": [
    {
      "sensorId": X,
      "type": "temperature",
      "unit": "celsius"
    },
    ...
  ],
  "meta": {
    "total": 100,
    "page": 1,
    "perPage": 10,
    "totalPages": 10
  }
}
```
## GET baseurl/api/v1/sensors/{id}
**success response:**
```json
{
  "status": "success",
  "message": "Sensor retrieved successfully.",
  "data": {
    "sensorId": X,
    "type": "temperature",
    "unit": "celsius"
  }
}
```
## POST baseurl/api/v1/stations/{id}
**request body:**
```json
{
  "staionId": "WSTATION-XXXXXXXX",     // required
  "name": null,                        // optional
  "description": null                  // optional
}
```
**success response:**
```json
{
  "status": "success",
  "message": "Station updated successfully.",
  "data": {  
    "staionId": "WSTATION-XXXXXXXX",
    "name": null,
    "description": null
  }
}
```
## POST baseurl/api/v1/stations/{id}/name
**request body:**
```json
{
  "staionId": "WSTATION-XXXXXXXX",     // required
  "name": null,                        // required
}
```
**success response:**
```json
{
  "status": "success",
  "message": "Station name updated successfully.",
  "data": {  
    "staionId": "WSTATION-XXXXXXXX",
    "name": null
  }
}
```
## POST baseurl/api/v1/stations/{id}/description
**request body:**
```json
{
  "staionId": "WSTATION-XXXXXXXX",     // required
  "description": null                  // required
}
```
**success response:**
```json
{
  "status": "success",
  "message": "Station descriptionn updated successfully.",
  "data": {  
    "staionId": "WSTATION-XXXXXXXX"
    "description": null
  }
}
```
# MQTT topics
**Send measurement (station):** /weatherstations/data/stations/{stationId}/measurement

**Update location (station):** /weatherstations/data/stations/{stationId}/location

**Subscribe to data (server):** /weatherstations/data/stations/#

# MQTT JSON messages format

## Station --> MQTT (data)
```json
{
  "temperature(C)": 24.46,
  "humidity(%)": 48.16699,
  "pressure(HPa)": 1032.109
}
```

## Station --> MQTT (location/register)
Als er nieuwe station is, gewoon toe voegen aan database.
```json
{
  "latitude": "XX.XXXXXX",
  "longitude": "XX.XXXXXX"
}
```
