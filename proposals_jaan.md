# Database structure proposal
## "stations" table
| column | PK | FK | type | nullable | auto increment |
| :----: | :----: | :----: | :----: | :----: | :----: |
| id | yes | no | string | no | no |
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
## Maybe "station_sensors" table?
| column | PK | FK | type | nullable | auto increment |
| :----: | :----: | :----: | :----: | :----: | :----: |
| station_id | yes | stations(id) | string | no | no |
| sensor_id | yes | sensors(id) | int | no | no |
# API endpoints proposal
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
    "description": null
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
## GET baseurl/api/v1/stations/{stationId}/sensors (if "station_sensors" table exists)
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
	    }
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
      "timestamp": "YYYY-MM-DDTHH:MM:SSZ",
      "stationId": "WSTATION-XXXXXXXX",
      "sensorId": X,
      "sensorValue": ""
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
# MQTT topics proposal
**Send measurement (station):** /data/stations/{stationId}/measurement

**Update location (station):** /data/stations/{stationId}/location

**Subscribe to data (server):** /data/stations/#

**Subscribe to data from specific station (web/app):** /data/stations/{stationId}/measurement

# MQTT JSON messages format proposal

## Station --> MQTT (data)
Dit is zeer modulair. Als er een sensor zou zijn die we nog niet kennen kunnen we deze ook gewoon toevoegen.
```json
{
  "timestamp": "YYYY-MM-DDTHH:MM:SSZ",
  "sensorType": "temprature",
  "sensorUnit": "celsius",
  "sensorValue": "15.7"
}
```

## Station --> MQTT (location/register)
Ook modulair als er nieuwe station is. gewoon toe voegen aan database.
```json
{
  "latitude": "XX.XXXXXX",
  "longitude": "XX.XXXXXX"
}
```
# General proposal
Voor de LIVE data stel ik voor dat de website of de app gewoon zelf een MQTT  connection over web sockets maakt met de broker en dan zelf zen data aanvult. Als ze historische data nodig hebben vragen ze dat aan de API.

voorbeeld, ze willen grafiek van data tonen:
1) ze vragen aan API data van nu tot x tijd geleden
--> api geeft data en ze plotten een graph
2) ze maken een websocket connectie met de MQTT broker en plotten de live data op de graph

