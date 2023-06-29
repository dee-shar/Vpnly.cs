#!/bin/bash

api="https://s3.hub-vpn.com"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36"

function get_servers() {
	curl --request GET \
		--url "$api/servers.json" \
		--user-agent "$user_agent"
}
